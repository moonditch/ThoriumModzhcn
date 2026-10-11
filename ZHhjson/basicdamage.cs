using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod.Items;

namespace ThoriumModzhcn.ZHhjson
{
    public class ItemTooltips : GlobalItem
    {
        private static readonly string[] TargetMods = new[]
        {
            "ThoriumMod",
            "ThoriumRework",
            "CalamityBardHealer",
            //"RedemptionBardHealer",
            //"SpiritBardHealer",
            //"SpookyBardHealer",
            //"SOTSBardHealer",
            //"MacroBardHealer",
            "RagnarokMod"
        };

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (var tooltipLine in tooltips)
            {
                if (string.IsNullOrEmpty(tooltipLine.Text))
                    continue;

                if (!tooltipLine.Text.Contains("basic damage"))
                    continue;

                if (!IsFromTargetMod(item, tooltipLine))
                    continue;

                tooltipLine.Text = tooltipLine.Text.Replace("basic damage", "基础伤害");
            }
        }

        private static bool IsFromTargetMod(Item item, TooltipLine tooltipLine)
        {

                if (!string.IsNullOrEmpty(tooltipLine.Mod) && TargetMods.Contains(tooltipLine.Mod))
                return true;
                        if (item.ModItem != null && item.ModItem.Mod != null)
                        {
                                string modName = item.ModItem.Mod.Name;

                if (TargetMods.Contains(modName))
                return true;
                }

                                return false;
		}
	}
}
