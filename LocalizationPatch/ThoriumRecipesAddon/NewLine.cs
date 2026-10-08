using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;
using Terraria.UI;
using ThoriumModzhcn.Systems;

namespace ThoriumModzhcn.LocalizationPatch.ThoriumRecipesAddon;

// ↓ 计算方法 (UIState)
// ThoriumRecipesAddon.Common.HintBook.HintBookUIState.RebuildWrappedIfNeeded

// ↓ 文本容器 (UIElement)
// ThoriumRecipesAddon.Common.HintBook.HintBookUIState.contentArea
// private HintBookUIState.CustomDrawElement contentArea;

// 可以直接引入dll文件，代替反射。

//[JITWhenModsEnabled(MODNAME)]
//[ExtendsFromMod(MODNAME)] 
public partial class NewLine : ModSystem
{
    //public const string MODNAME = "ThoriumRecipesAddon";
    private static WeakReference<UIState> weakHintBookUIState;
    private static WeakReference<UIElement> weakContentArea;
    private static WeakReference<UserInterface> weakUserInterface;
    private static int contentWidth;
    private static Dictionary<string, string> localizedCache = [];
    private static List<string> keys = [];
    private static bool addonIsLoad = true;

    public override void Load()
    {
        if (!ModLoader.TryGetMod("ThoriumRecipesAddon", out Mod mod)) {
            return;
        }

        var stateType = AssemblyManager.GetLoadableTypes(mod.Code).FirstOrDefault(t => t.FullName.Contains("ThoriumRecipesAddon.Common.HintBook.HintBookUIState"));

        // hook这个方法用来阻拦原模组的截词和断行。主要用于阻止这个逻辑的执行。
        //if (currentWidth + tokenW > maxWidth && current.Count > 0 && !isSpace)
        //{
        //    result.Add(current);
        //    current = new List<HintBookUIState.LineToken>();
        //    currentWidth = 0f;
        //}
        var wapMethod = stateType.GetMethod("WrapParagraph", BindingFlags.NonPublic | BindingFlags.Static);
        MonoModHooks.Add(wapMethod, delegate (Func<string, DynamicSpriteFont, float, object> orig, string text, DynamicSpriteFont font, float maxWidth) {
            if (LanguageManager.Instance.ActiveCulture != GameCulture.FromCultureName(GameCulture.CultureName.Chinese)) {
                orig(text, font, maxWidth);
            }
            return orig(text, font, float.MaxValue);
        });

    }

    public override void OnWorldLoad()
    {
        UpdateLocalizeText(contentWidth);
    }
    public override void UpdateUI(GameTime gameTime)
    {
        if (!addonIsLoad || !ModLoader.TryGetMod("ThoriumRecipesAddon", out _)) {
            addonIsLoad = false;
            return;
        }

        if (!weakUserInterface.TryGetTarget(out var userInterface)) {
            return;
        }

        if (!weakHintBookUIState.TryGetTarget(out var state) || userInterface.CurrentState != state) {
            return;
        }

        if (!weakContentArea.TryGetTarget(out var contentArea)) {
            return;
        }

        if (LanguageManager.Instance.ActiveCulture != GameCulture.FromCultureName(GameCulture.CultureName.Chinese)) {
            return;
        }
        var style = contentArea.GetInnerDimensions();
        if (contentWidth != (int)style.Width) {
            contentWidth = (int)style.Width;
            UpdateLocalizeText(contentWidth);
        }
    }

    public override void OnLocalizationsLoaded()
    {
        if (!ModLoader.TryGetMod("ThoriumRecipesAddon", out var mod)) {
            return;
        }
        localizedCache = LocalizeNew
            .LocalizedTexts
            .Where(a => a.Key.StartsWith("Mods.ThoriumRecipesAddon.HintBook"))
            .Select(a => new KeyValuePair<string, string>(a.Key, a.Value.Value))
            .ToDictionary()
            ;

        keys = [.. localizedCache.Keys];
        var bookSystem = mod.GetContent().FirstOrDefault(system => system.GetType().FullName.Contains("ThoriumRecipesAddon.Common.HintBook.HintBookSystem"));
        var bookSystemType = bookSystem.GetType();
        var hintBookUIStatePropty = bookSystemType.GetProperty("State", BindingFlags.Public | BindingFlags.Static);
        var hintBookUIState = (UIState)hintBookUIStatePropty.GetValue(bookSystem);
        weakHintBookUIState = new(hintBookUIState);

        var userInterface = bookSystemType.GetProperty("Interface", BindingFlags.Public | BindingFlags.Static);
        weakUserInterface = new((UserInterface)userInterface.GetValue(userInterface));

        var contentAreaFieldInfo = hintBookUIState.GetType().GetField("contentArea", BindingFlags.NonPublic | BindingFlags.Instance);
        var contentArea = (UIElement)contentAreaFieldInfo.GetValue(hintBookUIState);
        weakContentArea = new(contentArea);

        var style = contentArea.GetInnerDimensions();
        contentWidth = (int)style.Width;
        if (LanguageManager.Instance.ActiveCulture != GameCulture.FromCultureName(GameCulture.CultureName.Chinese)) {
            return;
        }

        UpdateLocalizeText(contentWidth);
    }

    //switch (token.Kind)
    //{
    //case HintBookUIState.TokenKind.Text:
    // 缩放有0.82
    //  ChatManager.DrawColorCodedStringWithShadow(sb, FontAssets.MouseText.Value, token.Text, new Vector2(cursorX, y), HintBookUIState.TextMain, 0f, Vector2.Zero, new Vector2(0.82f), -1f, 2f);

    private readonly static HashSet<char> symbol = ['，', '。', ',', '.', '!', '！', '?', '？', '、'];
    private static void UpdateLocalizeText(int width)
    {
        var texts = LocalizeNew.LocalizedTexts;

        foreach (var key in keys) {
            var text = texts[key];
            var rawText = localizedCache[key];
            var newText = rawText.Split("\n").Select(raw => WrapLine(raw, width));
            text.SetValue(string.Join("\n", newText));
            //text.SetValue(rawText);
        }
    }

    private static string WrapLine(string raw, float lineWidth)
    {
        var mouseText = FontAssets.MouseText;
        float scale = 0.82f;
        var matchCollectionKinds = MatchesKind(raw);

        List<int> insertNewLineIndex = [];
        float sumWidth = 0;

        for (int i = 0; i < raw.Length; i++) {
            var matchKind = GetCollectionKind(matchCollectionKinds, i);
            sumWidth += matchKind.Kind switch
            {
                // *2 是匹配物品绘制时的大小（可以超不能少）不然原模组那边又断一次行。这种问题最麻烦了
                Kind.ItemText or Kind.Mark => mouseText.Value.MeasureString("你").X * scale * 2,
                Kind.ColorText => mouseText.Value.MeasureString(matchKind.Match.Groups[1].Value).X * scale,
                _ => mouseText.Value.MeasureString(raw[i].ToString()).X * scale
            };

            i += matchKind.Match.Length > 0
                ? matchKind.Match.Length - 1
                : 0
                ;

            if (sumWidth >= lineWidth) {
                var newLineIndex = i;
                // 匹配到 [..] 内部 跳过
                if (matchKind.Kind != Kind.Unknown) {
                    newLineIndex = matchKind.Match.Index + matchKind.Match.Length;
                    i = newLineIndex /* - 1 */;
                }

                int p = i;
                while (p < raw.Length && symbol.Contains(raw[p])) p++;
                if (p < raw.Length) {
                    newLineIndex = p;
                    i = p - 1;
                }

                insertNewLineIndex.Add(newLineIndex);
                sumWidth = 0;
            }
        }

        if (insertNewLineIndex.Count == 0) {
            return raw;
        } else {
            var builder = new StringBuilder(raw)
                .Insert(insertNewLineIndex[0], '\n');
            for (int i = 1; i < insertNewLineIndex.Count; i++) {
                builder.Insert(insertNewLineIndex[i] + i, '\n');
            }
            return builder.ToString();
        }
    }

    public static MatchKind GetCollectionKind(MatchCollectionKind[] collectionKinds, int index)
    {
        foreach (var collectionKind in collectionKinds) {
            var match = collectionKind.Collection.FirstOrDefault(r => r.In(index));
            if (match != null) {
                return new MatchKind(match, collectionKind.Kind);
            }
        }
        return new MatchKind(Match.Empty, Kind.Unknown);
    }

    public static MatchCollectionKind[] MatchesKind(string raw)
    {
        return [
            new (MarkTextRegex().Matches(raw), Kind.Mark),
            new (ColorTextRegex().Matches(raw), Kind.ColorText),
            new (ItemTextRegex().Matches(raw), Kind.ItemText),
        ];
    }

    public record class MatchCollectionKind(MatchCollection Collection, Kind Kind);

    public record class MatchKind(Match Match, Kind Kind);

    public enum Kind
    {
        ItemText,
        Mark,
        ColorText,
        Unknown
    }
    //[GeneratedRegex(@"\[i(?:/[^:]*)?:([^\]]*)\]")] //@"\[i:([^\]]*)\]"
    private static Regex ColorTextRegex() => new Regex(@"\[c/[^:]+:([^\]]*)\]");
    private static Regex MarkTextRegex() => new Regex(@"\{[^{}]*\}");
    private static Regex ItemTextRegex() => new Regex(@"\[i(?:/[^:]*)?:([^\]]*)\]");
}

public static class MatchExtensions
{
    public static bool In(this Match match, int index)
    {
        return index >= match.Index && index < match.Index + match.Length;
    }
}


