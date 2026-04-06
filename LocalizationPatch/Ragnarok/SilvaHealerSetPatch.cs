using RagnarokMod.Items.HealerItems.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ThoriumModzhcn.LocalizationPatch.Ragnarok
{
    public class SilvaHealerSetPatch: GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("RagnarokMod");
        }
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            int[] silvaSet = 
                [
                    ModContent.ItemType<SilvaHeadHealer>(),
                    ModContent.Find<ModItem>("CalamityMod","SilvaArmor").Type,
                    ModContent.Find<ModItem>("CalamityMod","SilvaLeggings").Type
                ];
            foreach (var itemType in silvaSet) 
            {
                return entity.type == itemType;
            }
            return false;
        }
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ModContent.ItemType<SilvaHeadHealer>() && 
                body.type == ModContent.Find<ModItem>("CalamityMod", "SilvaArmor").Type && 
                legs.type == ModContent.Find<ModItem>("CalamityMod", "SilvaLeggings").Type) 
            {
                return Language.GetTextValue("Mods.RagnarokMod.Items.SilvaHeadHealer.SetBonus");
            }
             return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            player.setBonus = set;
        }
    }
}
