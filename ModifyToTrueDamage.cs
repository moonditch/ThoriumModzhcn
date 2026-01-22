using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumModzhcn.Systems;

namespace ThoriumModzhcn;

public class ModifyToTrueDamage : GlobalItem
{
    public readonly static string simpleValue = "真实伤害";
    public readonly static string traditionalValue = "真實傷害";
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        // Terraria/Damage
        if (item.damage <= 0 || item.DamageType != ThoriumDamageBase<TrueDamage>.Instance) return;
        TooltipLine damageTooltip = tooltips.Find(tt => tt.FullName == "Terraria/Damage");
        string damageValue = damageTooltip.Text.Split(' ')[0];
        damageTooltip.Text = damageValue + " " + 
            (LocalizeNew.CurrentLanguage == Language.简体中文 ? simpleValue : traditionalValue);
        base.ModifyTooltips(item, tooltips);
    }
}