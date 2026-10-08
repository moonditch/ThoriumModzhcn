using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ThoriumModzhcn.ZHhjson
{
    public class ItemTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (!ModLoader.TryGetMod("ThoriumMod", out Mod thoriumMod))
                return;

                foreach (var tooltipLine in tooltips)
                {
                if (tooltipLine.Text.Contains("basic damage"))
                {
                    tooltipLine.Text = tooltipLine.Text.Replace("basic damage", "基础伤害");
               }
            }
        }
    }
}