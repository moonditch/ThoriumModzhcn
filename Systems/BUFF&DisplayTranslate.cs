using Terraria;
using ThoriumMod;
using Terraria.ModLoader;
using ThoriumMod.Utilities;
using ThoriumMod.Buffs.Healer;
using ThoriumMod.UI.ResourceBars;
using System;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using MonoMod.RuntimeDetour;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using MonoMod.Cil;

namespace ThoriumModzhcn.Systems
{
    //瑟银重置世界频道+ui秒
    public class StatsTranslate : ModSystem
    {
	    private Hook _hookDisplayIconNearEquips;
        private ILHook _hookOnEnterWorld;

		public override void Load()
		{
			var methodDisplayIconNearEquips = typeof(InformationalIcons).GetMethod("DisplayIconNearEquips", BindingFlags.Static | BindingFlags.NonPublic);
			if (methodDisplayIconNearEquips is not null)
			{
				_hookDisplayIconNearEquips = new Hook(methodDisplayIconNearEquips, DisplayIconNearEquips);
				_hookDisplayIconNearEquips.Apply();
			}

            if (ModLoader.TryGetMod("ThoriumRework", out Mod thoriumRework))
            {
	            var methodOnEnterWorld = thoriumRework.GetType().Assembly.GetTypes().First(type => type.Name == "ThoriumPlayer").GetMethod("OnEnterWorld", BindingFlags.Instance | BindingFlags.Public);
	            if (methodOnEnterWorld is not null)
	            {
		            _hookOnEnterWorld = new ILHook(methodOnEnterWorld, OnEnterWorld);
                    _hookOnEnterWorld.Apply();
				}
            }

            // On_ChatManager.ParseMessage += Translate;
        }
        public override void Unload()
        {
            if (_hookDisplayIconNearEquips is not null)
            {
                _hookDisplayIconNearEquips.Dispose();
                _hookDisplayIconNearEquips = null;
            }

            if (_hookOnEnterWorld is not null)
            {
                _hookOnEnterWorld.Dispose();
                _hookOnEnterWorld = null;
			}
			// On_ChatManager.ParseMessage -= Translate;
		}

		private delegate void DisplayIconNearEquipsDelegate(SpriteBatch spriteBatch, Texture2D tex, int yOffDefault, float yOffFactor, string iconText, string iconTextSuf, Vector2 iconTextOffset, string mouseText);

		private static void DisplayIconNearEquips(DisplayIconNearEquipsDelegate orig, SpriteBatch spriteBatch, Texture2D tex, int yOffDefault, float yOffFactor, string iconText, string iconTextSuf, Vector2 iconTextOffset, string mouseText)
		{
			if (iconTextSuf == " sec")
				iconTextSuf = " 秒";
			orig.Invoke(spriteBatch, tex, yOffDefault, yOffFactor, iconText, iconTextSuf, iconTextOffset, mouseText);
        }

        private static void OnEnterWorld(ILContext ilContext)
        {
	        var cursor = new ILCursor(ilContext);

            if (!cursor.TryGotoNext(i => i.MatchLdstr("PHOTOSENSITIVITY WARNING: \"Thorium Bosses Rework\" mod adds a lot of flashy effects! Especially in boss fights!\nIf you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!\nYou can turn off this warning in the config as well if you do not want to keep seeing it!")))
				return;
            cursor.Index++;
            cursor.EmitDelegate<Func<string, string>>((eng) => "光 敏 警 告：“Thorium Bosses Rework”模组增加了很多华丽的效果！尤其是在boss战中！\n如果你感觉到不适，请转到设置 -> 模组配置 -> Thorium Bosses Rework -> 视觉设置，并将所有设置调整为0！\n如果你不想看到这个警告，也可以在配置中关闭它！");
        } 
    }

    //灵魂精华buff
    public class BuffTrans : GlobalBuff
    {
        public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
        {
            if (type == ModContent.BuffType<SoulEssence>())
            {
                ThoriumPlayer thoriumPlayer = Main.LocalPlayer.GetThoriumPlayer();
                tip = $"每获得5点灵魂精华，恢复（{1 + thoriumPlayer.healBonus}）生命和（{3 + thoriumPlayer.healBonus * 3}）魔力";
            }
        }
    } 
}