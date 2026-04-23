using JetBrains.Annotations;
using Microsoft.Build.Utilities;
using Microsoft.Xna.Framework;
using RagnarokMod.Common.GlobalItems;
using RagnarokMod.ILEditing;
using RagnarokMod.Items.BardItems.Armor;
using RagnarokMod.Items.Placeables.Paintings;
using RagnarokMod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using ThoriumMod;

namespace ThoriumModzhcn.LocalizationPatch.Ragnarok
{
    //TODO - 更新 诸神的黄昏 程序集

    [JITWhenModsEnabled("RagnarokMod")]
    public class RagnarokHookPatch : ModSystem
    {
        private delegate void Oirg_TweakToolTips_ModifyTooltips(TweakToolTips self, Item item, List<TooltipLine> tooltips);
        private delegate void Oirg_FateoftheGods_ModifyTooltips(FateoftheGods self, List<TooltipLine> tooltips);
        private delegate void Oirg_IntergelacticRobohelm_UpdateArmorSet(IntergelacticRobohelm self, Player player);

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
            //异宇星凝乐师套装奖励
            IntergelacticBardSetBonus();
        }

        private void IntergelacticBardSetBonus() 
        {
            if (!ModLoader.TryGetMod("RagnarokMod", out Mod mod))
                return;

            Type type = mod.Code.GetType("RagnarokMod.Items.BardItems.Armor.IntergelacticRobohelm");

            MethodInfo method = type?.GetMethod("UpdateArmorSet", BindingFlags.Instance | BindingFlags.Public);

            if (method is not null)
                MonoModHooks.Add(method, On_IntergelacticRobohelm_UpdateArmorSet);
        }
        private static void On_IntergelacticRobohelm_UpdateArmorSet(Oirg_IntergelacticRobohelm_UpdateArmorSet orig , IntergelacticRobohelm self, Player player) 
        {
            if (ModLoader.TryGetMod("CatalystMod", out Mod CatalystMod))
            {
                Item item = new Item();
                item.SetDefaults(CatalystMod.Find<ModItem>("IntergelacticHeadMelee").Type);
                item.DamageType = ThoriumDamageBase<BardDamage>.Instance;
                if (item.ModItem != null)
                {
                    ModItem modItem = item.ModItem;
                    if (modItem != null && player.GetRagnarokModPlayer().asteroidexhaustioncounter == 0)
                    {
                        modItem.UpdateArmorSet(player);
                        player.setBonus = player.setBonus.Replace("四个", "两个");
                        player.setBonus = player.setBonus +
                            "\n星环击中敌怪有5%概率提供随机1-3级咒音增幅" +
                            "\n按下“盔甲能力”会消耗星环恢复100点灵感值，并触发所有4级资源型咒音增幅";
                    }
                    if (player.GetRagnarokModPlayer().asteroidexhaustioncounter != 0)
                    {
                        player.setBonus = player.setBonus + 
                            "\n星环的力量已耗尽";
                    }
                    player.noKnockback = true;
                    player.buffImmune[32] = true;
                    player.buffImmune[33] = true;
                    player.buffImmune[46] = true;
                    player.buffImmune[47] = true;
                    player.buffImmune[156] = true;
                    player.buffImmune[31] = true;
                    player.buffImmune[197] = true;
                    player.buffImmune[ModContent.Find<ModBuff>("CalamityMod", "GlacialState").Type] = true;
                    player.buffImmune[CatalystMod.Find<ModBuff>("AstralBlight").Type] = true;
                    player.GetRagnarokModPlayer().intergelacticBard = true;
                }
            }
        }
        private void FateoftheGodsHook() 
        {
            if (!ModLoader.TryGetMod("RagnarokMod", out Mod mod))
                return;

            Type type = mod.Code.GetType("RagnarokMod.Items.Placeables.Paintings.FateoftheGods");

            MethodInfo method = type?.GetMethod("ModifyTooltips", BindingFlags.Instance | BindingFlags.Public);

            if (method is not null)
                MonoModHooks.Add(method, On_FateoftheGods_ModifyTooltips);
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
