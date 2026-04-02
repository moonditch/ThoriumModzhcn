using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumModzhcn.Core;

namespace ThoriumModzhcn.LocalizationPatch.Ragnarok
{
    public class RagnarokCommonPatch
    {
        private static readonly string cal = "CalamityMod";
        private static readonly string thor = "ThoriumMod";
        public static int IsItemExist(string mod, string item)
        {
            return ModContent.TryFind<ModItem>(mod, item, out ModItem modItem) ? modItem.Type : -1;
        }

        public static int IsBuffExist(string mod, string buff)
        {
            return ModContent.TryFind<ModBuff>(mod, buff, out ModBuff modBuff) ? modBuff.Type : -1;
        }

        [JITWhenModsEnabled("CalamityMod")]
        public class RagnarokItems : GlobalItem
        {
            
            private static readonly Dictionary<string,Dictionary<string, int>> Items = new() 
            {
                //灾厄
                ["StarBeamRye"] = new() { [cal] = IsItemExist(cal, "StarBeamRye")}
                //瑟银
            };

            public override bool InstancePerEntity => true;
            public override bool IsLoadingEnabled(Mod mod)
            {
                return ModLoader.HasMod("RagnarokMod");
            }

            public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
            {
                if (item.ModItem is null)
                    return;

                foreach (var Item in Items) {
                    foreach (var target in Item.Value)
                    {
                        if (target.Value == -1)
                            return;

                        if (item.type == target.Value)
                        {
                            Utilities.FullTooltipOveride(tooltips, Language.GetTextValue($"Mods.ThoriumModzhcn.RagnarokMod.{target.Key}.Items.{Item.Key}.Tooltip"));
                        }
                    }
                }
            }
        }

        [JITWhenModsEnabled("CalamityMod")]
        public class RagnarokBuffs : GlobalBuff
        {
            public static readonly Dictionary<string, Dictionary<string, int>> Buffs = new() {
                //瑟银
                //灾厄
                ["StarBeamRyeBuff"] = new() { [cal] = IsBuffExist(cal, "StarBeamRyeBuff") }
            };
            public override bool IsLoadingEnabled(Mod mod)
            {
                return ModLoader.HasMod("RagnarokMod");
            }

            public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
            {
                foreach (var Buff in Buffs) 
                {
                    foreach (var target in Buff.Value)
                    {
                        if (target.Value == -1)
                            return;

                        if (type == target.Value)
                        {
                            tip = Language.GetTextValue($"Mods.ThoriumModzhcn.RagnarokMod.{target.Key}.Buffs.{Buff.Key}.Description");
                        }
                    }
                }
            }
        }
    }
}
