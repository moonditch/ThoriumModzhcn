using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using static ThoriumModzhcn.Systems.LocalizeExtend;

namespace ThoriumModzhcn.Systems;

public class LocalizeNew : ModSystem
{
    #region
    /*public static List<string> PCRHJson { get; } =
     [
    ];

    public static List<string> CSOWHJson { get; } =
     [
    ];*/
    

    //Unsimplifiedzh or zh-TW
    public static List<TFile> TWHJson { get; set; }

    //Simplifiedzh or zh-Hans
    public static List<TFile> ZHHJson { get; set; }
    #endregion
    public static Language CurrentLanguage { get; set; } = Language.简体中文;
    public readonly static string ModName = typeof(LocalizeNew).FullName.Split('.')[0];

    [ModuleInitializer]
    public static void LoadLocalizationJson()
    {
        var allHjson = TFile.GetFiles(f => f.EndsWith(".hjson"));
        TWHJson = allHjson
            .Where(file => file.FilePath.Contains("Unsimplifiedzh") || file.FilePath.Contains("zh-TW"))
            .ToList();

        ZHHJson = allHjson
            .Where(file => file.FilePath.Contains("Simplifiedzh") || file.FilePath.Contains("zh-Hans"))
            .ToList();
        ;
        var tfile = allHjson.Where(f => f.FilePath.Contains("zh-Hans_Mods.ThoriumMod")).First();
        if (LoadModAssembly.LoadModContext.ContainsKey("RagnarokMod"))
        {
        ZHHJson.Add(tfile);
      }
RegionILKey(ZHHJson);

        RegionILKey(ZHHJson);
    }

    public static void LangSwitcher()
    {
        switch (CurrentLanguage) {
            case Language.简体中文:
                OverrideKeyValue(ZHHJson);
                break;
            default:
                OverrideKeyValue(TWHJson);
                break;
        }
    }

    public static bool IsPostSetupContent;
    public override void PostSetupContent()
    {
        IsPostSetupContent = true;
        base.PostSetupContent();
    }

    /// <summary>
    /// 给定文件路径，读取值并覆盖
    /// </summary>
    public static void OverrideKeyValue(IEnumerable<TFile> filePaths)
    {
        foreach (var fp in filePaths) {
            var fullstring = fp.GetText();
            List<(string key, string value)> parserValue = fp.ParseToKeyValue();

            foreach (var (key, value) in parserValue) {
                var list = parserValue.Where(f => f.value.Contains("$")).ToList();
                if (!LocalizedTexts.TryGetValue(key, out var tartext)) {
                    LocalizedTexts.Add(key, CreateLocalizedText(key, value));
                } else {
                    tartext.SetValue(value);
                }
            }
        }
    }

    /// <summary>
    /// 注册IL键 文件名称请以"IL_"开头
    /// </summary>
    public static void RegionILKey(IEnumerable<TFile> filePaths)
    {
        var ILHjson = filePaths.Where(fp => fp.FilePath.Contains("IL_"));
        foreach (var file in ILHjson) {
            string hjsonValue = file.GetText();
            var kv = file.ParseToKeyValue();
            foreach (var (key, value) in kv) {
                if(!LocalizedTexts.TryGetValue(key, out _)){
                    LocalizedTexts[key] = CreateLocalizedText(key, value);
                }
            }
        }
    }

    private static Dictionary<string, LocalizedText>? localizedTexts;
    public static Dictionary<string, LocalizedText> LocalizedTexts
    {
        get
        {
            return localizedTexts ??=
                (Dictionary<string, LocalizedText>)typeof(LanguageManager)!
                    .GetField("_localizedTexts", BindingFlags.NonPublic | BindingFlags.Instance)!
                    .GetValue(LanguageManager.Instance)!;
        }
    }

}

public static class LocalizeExtend
{
    private static MethodInfo getTextValue;
    public static MethodInfo GetTextValue => getTextValue ??= typeof(Terraria.Localization.Language).GetMethods().FirstOrDefault(met => met.Name == "GetTextValue" && met.GetParameters().Length == 1);

    private static MethodInfo? localizedTextSetValue;
    public static MethodInfo LocalizedTextSetValue =>
        localizedTextSetValue ??=
        typeof(LocalizedText).GetProperty(nameof(LocalizedText.Value))!.GetSetMethod(true)!;

    public static void SetValue(this LocalizedText lx, string value)
    {
        LocalizedTextSetValue.Invoke(lx, [value]);
    }

    private readonly static ConstructorInfo LocalizedTextCtor = typeof(LocalizedText).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, [typeof(string), typeof(string)])!;

    public static LocalizedText CreateLocalizedText(string Key, string Value)
    {
        return (LocalizedText)LocalizedTextCtor.Invoke([Key, Value]);
    }

}

public class 语言切换 : ModConfig
{
    public Language 语言;

    [JsonIgnore]
    public CancellationTokenSource CTS;

    public override ConfigScope Mode => ConfigScope.ClientSide;

    public override void OnChanged()
    {
        if (CTS == null) {
            CTS = new CancellationTokenSource();
        } else {
            CTS.Cancel();
            CTS = new CancellationTokenSource();
        }

        LocalizeNew.CurrentLanguage = 语言;
        if (LocalizeNew.IsPostSetupContent) {
            _ = Task.Run(() => {
               LanguageManager.Instance.RecalculateBoundTextValues();
            }/*, CTS.Token*/);
        }

        base.OnChanged();
    }
}


