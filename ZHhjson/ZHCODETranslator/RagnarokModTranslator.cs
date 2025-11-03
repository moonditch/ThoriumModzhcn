#pragma warning disable CA2255
using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace ThoriumModzhcn.ZHhjson.ZHCODETranslator
{
	public class RagnarokModTranslator
	{
		private class RagnarokMod{}
		[ExtendsFromMod("RagnarokMod"), JITWhenModsEnabled("RagnarokMod")]
		private class TranslatorLoad : ForceLocalizeSystem<RagnarokMod, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("RagnarokMod",out _))
			{
				#region RagnarokMod.Utils.RagnarokModPlayer
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Utils.RagnarokModPlayer", "AddStealth", new ()
				{
					{"RagnarokMod.RagnarokMod.Utils.RagnarokModPlayer.AddStealth.42"," maximum stealth"},
				});
				#endregion RagnarokMod.Utils.RagnarokModPlayer


				#region RagnarokMod.Items.HealerItems.Armor.TarragonCowl
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Items.HealerItems.Armor.TarragonCowl", "UpdateArmorSet", new ()
				{
					{"RagnarokMod.RagnarokMod.Items.HealerItems.Armor.TarragonCowl.UpdateArmorSet.86","Increased heart pickup range\nEnemies have a chance to drop extra hearts on death\nA Guardian healer will assist you in healing your allies\nHeals ally life equal to your bonus healing + 5 health\nand grants them the Guardian Healers Blessing for 20 seconds"},
				});
				#endregion RagnarokMod.Items.HealerItems.Armor.TarragonCowl


				#region RagnarokMod.Items.HealerItems.Armor.VictideHeadHealer
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Items.HealerItems.Armor.VictideHeadHealer", "UpdateArmorSet", new ()
				{
					{"RagnarokMod.RagnarokMod.Items.HealerItems.Armor.VictideHeadHealer.UpdateArmorSet.89","Enemies are less likely to target you\n+3 life regen and 10% increased radiant but 10% decreased non-radiant damage while submerged in liquid\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nProvides increased underwater mobility and slightly reduces breath loss in the abyss"},
				});
				#endregion RagnarokMod.Items.HealerItems.Armor.VictideHeadHealer


				#region RagnarokMod.Items.BardItems.Armor.TarragonShroud
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Items.BardItems.Armor.TarragonShroud", "UpdateArmorSet", new ()
				{
					{"RagnarokMod.RagnarokMod.Items.BardItems.Armor.TarragonShroud.UpdateArmorSet.101","Increased heart pickup range\nEnemies have a chance to drop extra hearts on death\nAll buff duration enhancements are prolonged for additional 50%\nSet bonus of Ornate armor"},
				});
				#endregion RagnarokMod.Items.BardItems.Armor.TarragonShroud


				#region RagnarokMod.Items.BardItems.Armor.VictideHeadBard
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Items.BardItems.Armor.VictideHeadBard", "UpdateArmorSet", new ()
				{
					{"RagnarokMod.RagnarokMod.Items.BardItems.Armor.VictideHeadBard.UpdateArmorSet.105","Enemies are less likely to target you\n+3 life regen and 10% increased symphonic damage while submerged in liquid\nWhen using any weapon you have a 10% chance to throw a returning seashell projectile\nThis seashell does true damage and does not benefit from any damage class\nProvides increased underwater mobility and slightly reduces breath loss in the abyss"},
				});
				#endregion RagnarokMod.Items.BardItems.Armor.VictideHeadBard


				#region RagnarokMod.Common.GlobalItems.CalamityRogueTechPoints
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Common.GlobalItems.CalamityRogueTechPoints", "ModifyTooltips", new ()
				{
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.CalamityRogueTechPoints.ModifyTooltips.372","\nIncreases your maximum technique points by "},
				});
				#endregion RagnarokMod.Common.GlobalItems.CalamityRogueTechPoints


				#region RagnarokMod.Common.GlobalItems.ReworkClassRings
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Common.GlobalItems.ReworkClassRings", "ModifyTooltips", new ()
				{
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.822","\n3% increased symphonic damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.823","\n3% increased melee damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.824","\n3% increased summon damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.825","\n3% increased rogue damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.826","\n3% increased ranged damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.827","\n3% increased radiant damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.828","\n3% increased magic damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.829","Increases armor penetration by 2"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ReworkClassRings.ModifyTooltips.830","Increases armor penetration by 3\nIncreases damage by 4%"},
				});
				#endregion RagnarokMod.Common.GlobalItems.ReworkClassRings

				#region RagnarokMod.Common.GlobalItems.ItemBalancer
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Common.GlobalItems.ItemBalancer", "ModifyTooltips", new ()
				{
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.401","\nDoes not work in the Abyss but instead grants you and your allies +10 defense and +20% movement speed\nYou also randomly get some oxygen back"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.967","\nUnderwater breath does not work in the Abyss"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.970","25% basic damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.972","Projectile damage caps at 500"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.974","75% basic damage"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.976","Projectile damage caps at 2000"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.979","12.5% of your rogue damage is duplicated"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.981","Duplication damage caps at 50. Effect does not stack with other Guides"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.983","15% of your rogue damage is duplicated"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.985","Duplication damage caps at 100. Effect does not stack with other Guides"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.987","17.5% of your rogue damage is duplicated"},
					{"RagnarokMod.RagnarokMod.Common.GlobalItems.ItemBalancer.ModifyTooltips.988","Duplication damage caps at 200. Effect does not stack with other Guides"},
				});
				#endregion RagnarokMod.Common.GlobalItems.ItemBalancer


			}
		}
	}
}
