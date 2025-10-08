#pragma warning disable CA2255 // 不应在库中使用 “ModuleInitializer” 属性
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Graphics;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;

namespace ThoriumModzhcn.FontColor;

public static class OnUIModItem
{
    private readonly static Type _uiText = typeof(UIText);
    private readonly static Type _uIModItemType = typeof(ModLoader).Assembly.GetType("Terraria.ModLoader.UI.UIModItem");
    private readonly static FieldInfo _displayNameClean = _uIModItemType.GetField("DisplayNameClean");
    private static Asset<Effect> fontShader;
    private static Asset<Texture2D> fontClorTexture2D;
    private static Asset<DynamicSpriteFont> font;
    private readonly static string contains = typeof(OnUIModItem).FullName.Split(".")[0];

    internal delegate void UITextDrawSelfD(UIText ui, SpriteBatch spriteBatch);

    internal static void UITextDrawSelfMethod(UITextDrawSelfD orig, UIText ui, SpriteBatch sb)
    {
        if (ui.Parent.GetType() == _uIModItemType && _displayNameClean.GetValue(ui.Parent).ToString().Equals(ModLoader.GetMod(contains).DisplayNameClean))
        {
            fontShader ??= ModContent.Request<Effect>(typeof(OnUIModItem).Namespace.Replace(".", "/") + "/FontShader", AssetRequestMode.ImmediateLoad);
            fontClorTexture2D ??= ModContent.Request<Texture2D>(typeof(OnUIModItem).Namespace.Replace(".", "/") + "/FontColor", AssetRequestMode.ImmediateLoad);
            //font ??= ModContent.Request<DynamicSpriteFont>(typeof(OnUIModItem).Namespace.Replace(".", "/") + "/华文细黑", AssetRequestMode.ImmediateLoad);

            var pos = ui.GetDimensions().Position();
            sb.End();
            var gd = sb.GraphicsDevice;
            sb.Begin(SpriteSortMode.Immediate, gd.BlendState, SamplerState.PointWrap, gd.DepthStencilState, gd.RasterizerState, fontShader.Value, Main.UIScaleMatrix);
            gd.Textures[1] = fontClorTexture2D.Value;
            var time = (float)Main.gameTimeCache.TotalGameTime.TotalSeconds;
            fontShader.Value.Parameters["uTime"].SetValue(time);
            fontShader.Value.Parameters["scrollSpeed"].SetValue(0.1f);
            sb.DrawString(FontAssets.MouseText.Value, ui.Text, pos, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1f);
            sb.End();
            sb.Begin(SpriteSortMode.Deferred, sb.GraphicsDevice.BlendState, sb.GraphicsDevice.SamplerStates[0], sb.GraphicsDevice.DepthStencilState, sb.GraphicsDevice.RasterizerState, null, Main.UIScaleMatrix);

            //drawSelfSpriteBatch.Begin();
            //drawSelfSpriteBatch.GraphicsDevice.SetRenderTarget(drawSelfRT2D);
            //drawSelfSpriteBatch.GraphicsDevice.Clear(Color.Transparent);
            //var pos = ui.GetDimensions().Position();
            //drawSelfSpriteBatch.DrawString(FontAssets.MouseText.Value,ui.Text, pos, Color.White);
            //drawSelfSpriteBatch.End();
            //drawSelfSpriteBatch.GraphicsDevice.SetRenderTarget(null);
            //drawSelfSpriteBatch.Begin();
            //drawSelfSpriteBatch.Draw(drawSelfRT2D, Vector2.Zero, Color.White);
            //drawSelfSpriteBatch.End();
        }
        else
        {
            orig.Invoke(ui, sb);
        }
    }

    [ModuleInitializer]
    internal static void ApplyModName()
    {
        var drawSelf = _uiText.GetMethod("DrawSelf", BindingFlags.Instance | BindingFlags.NonPublic);
        MonoModHooks.Add(drawSelf, UITextDrawSelfMethod);
    }

}
