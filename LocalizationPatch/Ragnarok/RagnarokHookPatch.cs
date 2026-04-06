using JetBrains.Annotations;
using Microsoft.Build.Utilities;
using RagnarokMod.Common.GlobalItems;
using RagnarokMod.ILEditing;
using RagnarokMod.Items.Placeables.Paintings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ThoriumModzhcn.LocalizationPatch.Ragnarok
{
    [JITWhenModsEnabled("RagnarokMod")]
    public class RagnarokHookPatch : ModSystem
    {
        private delegate void Oirg_TweakToolTips_ModifyTooltips(TweakToolTips self, Item item, List<TooltipLine> tooltips);
        private delegate void Oirg_FateoftheGods_ModifyTooltips(FateoftheGods self, List<TooltipLine> tooltips);

        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("RagnarokMod");
        }

        public override void Load()
        {
            //归一心元石 惧魂神物
            TweakToolTipsHook();
            //众神命数
            FateoftheGodsHook();
        }

        private void FateoftheGodsHook() 
        {
            if (!ModLoader.TryGetMod("RagnarokMod", out Mod mod))
                return;

            var obj = new FateoftheGods();

            Type type = mod.Code.GetType("RagnarokMod.Items.Placeables.Paintings.FateoftheGods");
           
            MethodInfo method = type?.GetMethod("ModifyTooltips", BindingFlags.Instance | BindingFlags.Public);

            if (method is not null)
                MonoModHooks.Add(method, On_FateoftheGods_ModifyTooltips);

            //FieldInfo fieldInfo = type?.GetField("devList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            //var newList = new List<string>
            //{
            //    "\n[c/96FF96:贡献者]:\n",
            //    "FireFlameJoe, ",
            //    "TheUnknownNerd, ",
            //    "HayWire799, ",
            //    "Aeolus",

            //    "\n[c/FFFF0A:美术]:\n",
            //    "Ochette, ",
            //    "Kyou, ",
            //    "Delly, ",
            //    "e³, ",
            //    "Bence, ",
            //    "TheStormQueen, ",
            //    "Imonthatgudkush",

            //    "\n[c/FF2864:程序员]:\n",
            //    "CrafterDaemon, ",
            //    "Patrick1234, ",
            //    "Frogleader, ",
            //    "Akira, ",
            //    "WardrobeHummus, ",
            //    "Ropro0923",

            //    "\n[c/9696FF:其他开发者]:\n",
            //    "TelosRyu, ",
            //    "Deeno, ",
            //    "Moon_Ditch"
            //};

            //if (fieldInfo is null)
            //    Mod.Logger.Warn("The fieldInfo is null");

            //fieldInfo.SetValue(obj, newList);
        }
        private static void On_FateoftheGods_ModifyTooltips(Oirg_FateoftheGods_ModifyTooltips orig, FateoftheGods self, List<TooltipLine> tooltips)
        {
            var devList = new List<string>
            {
                "\n[c/96FF96:贡献者]:\n",
                "FireFlameJoe, ",
                "TheUnknownNerd, ",
                "HayWire799, ",
                "Aeolus",
                "\n[c/FFFF0A:美术]:\n",
                "Ochette, ",
                "Kyou, ",
                "Delly, ",
                "e³, ",
                "Bence, ",
                "TheStormQueen, ",
                "Imonthatgudkush",
                "\n[c/FF2864:程序员]:\n",
                "CrafterDaemon, ",
                "Patrick1234, ",
                "Frogleader, ",
                "Akira, ",
                "WardrobeHummus, ",
                "Ropro0923",
                "\n[c/9696FF:其他开发者]:\n",
                "TelosRyu, ",
                "Deeno, ",
                "Moon_Ditch"
            };

            if (!Main.keyState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.LeftShift))
                return;

            string tooltip = "";

            for (int i = 0; i < devList.Count; i++)
            {
                tooltip += devList[i];

                if (i == devList.Count - 1)
                    break;
            }

            TooltipLine line = tooltips.FirstOrDefault(t => t.Mod == "Terraria" && t.Name == "Tooltip2");
            if (line != null)
                line.Text = tooltip;
            
        }
        private void TweakToolTipsHook() 
        {
            if (!ModLoader.TryGetMod("RagnarokMod", out Mod mod))
                return;

            Type type = mod.Code.GetType("RagnarokMod.Common.GlobalItems.TweakToolTips");

            MethodInfo method = type?.GetMethod("ModifyTooltips", BindingFlags.Instance | BindingFlags.Public);

            if (method is not null)
                MonoModHooks.Add(method, On_TweakToolTips_ModifyTooltips);
        }
        private static void On_TweakToolTips_ModifyTooltips(Oirg_TweakToolTips_ModifyTooltips orig, TweakToolTips self, Item item, List<TooltipLine> tooltips)
        {
            if (!ModLoader.TryGetMod("CalamityMod", out Mod cal))
                return;

            if (item.type == cal.Find<ModItem>("TheCommunity").Type)
            {
                for (int i = 0; i < tooltips.Count; i++)
                {
                    if (tooltips[i].Text.Contains("已解锁"))
                    {
                        tooltips[i].Text = System.Text.RegularExpressions.Regex.Replace(
                        tooltips[i].Text,
                        @"已解锁\d+%",
                        $"{Math.Round(CalamityEdits.calculateCommunityPower() * 100)}" + Language.GetTextValue("Mods.RagnarokMod.Compat.Power")
                        );
                    }
                }
            }

            if (item.type == cal.Find<ModItem>("EldritchSoulArtifact").Type)
            {
                for (int i = 0; i < tooltips.Count; i++)
                {
                    if (tooltips[i].Text.Contains("增加"))
                    {
                        tooltips[i].Text += "\n增加2点最大灵感值和2点额外治疗量";
                    }
                }
            }
        }
    }
}
