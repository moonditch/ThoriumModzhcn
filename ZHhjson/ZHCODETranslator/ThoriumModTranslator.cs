using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ZHhjson.ZHCODETranslator
{
	public class ThoriumModTranslator
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				//物品需求
				#region ThoriumMod.ThoriumPlayer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.ThoriumPlayer", "PostUpdateEquips", new ()
				{
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.PostUpdateEquips.142"," life heal streak"},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.ThoriumPlayer", "AddCoinTooltip", new ()
				{
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.167"," gold, "},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.168"," gold, and "},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.169"," silver, and "},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.170"," silver"},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.171"," copper"},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.172","0 coins"},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.176","MoneyAmount"},
				});
				#endregion ThoriumMod.ThoriumPlayer


				#region ThoriumMod.UI.TrackerUI
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.UI.TrackerUI", "OnInitialize", new ()
				{
					{"ThoriumMod.ThoriumMod.UI.TrackerUI.OnInitialize.473","Close"},
					{"ThoriumMod.ThoriumMod.UI.TrackerUI.OnInitialize.475","Previous"},
					{"ThoriumMod.ThoriumMod.UI.TrackerUI.OnInitialize.477","Next"},
				});
				#endregion ThoriumMod.UI.TrackerUI


				#region ThoriumMod.Items.ThoriumGlobalItem
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThoriumGlobalItem", "AddCookText", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThoriumGlobalItem.AddCookText.2916","The cook might be interested in this: "},
				});
				#endregion ThoriumMod.Items.ThoriumGlobalItem


				#region ThoriumMod.Items.ThoriumItem
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThoriumItem", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2933","-Reality Breaker-"},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2935","-Transformation-"},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2937","-Thrower Class-"},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2939","-Healer Class-"},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2941","Grants "},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2942"," soul essence on direct hit"},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2943"," & "},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2944"," life"},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2945"," by "},
					{"ThoriumMod.ThoriumMod.Items.ThoriumItem.ModifyTooltips.2949"," equal to your bonus healing"},
				});
				#endregion ThoriumMod.Items.ThoriumItem


				#region ThoriumMod.Items.ZRemoved.StonePurple
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ZRemoved.StonePurple", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ZRemoved.StonePurple.ModifyTooltips.2988","1% of targets health as true damage"},
				});
				#endregion ThoriumMod.Items.ZRemoved.StonePurple


				#region ThoriumMod.Items.TransformItems.SoulLink
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.TransformItems.SoulLink", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.TransformItems.SoulLink.ModifyTooltips.3004","-Early Testing-"},
					{"ThoriumMod.ThoriumMod.Items.TransformItems.SoulLink.ModifyTooltips.3031","Allows you to use unique abilities while transformed"},
				});
				#endregion ThoriumMod.Items.TransformItems.SoulLink


				#region ThoriumMod.Items.Thorium.Crietz
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Thorium.Crietz", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Thorium.Crietz.SetDefaults.3039","15 basic damage"},
				});
				#endregion ThoriumMod.Items.Thorium.Crietz


				#region ThoriumMod.Items.SummonItems.CrystalScorpion
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.SummonItems.CrystalScorpion", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.SummonItems.CrystalScorpion.SetDefaults.3063","25 basic damage"},
				});
				#endregion ThoriumMod.Items.SummonItems.CrystalScorpion


				#region ThoriumMod.Items.SummonItems.IncubatedEgg
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.SummonItems.IncubatedEgg", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.SummonItems.IncubatedEgg.SetDefaults.3064","14 basic damage"},
				});
				#endregion ThoriumMod.Items.SummonItems.IncubatedEgg


				#region ThoriumMod.Items.SummonItems.PrehistoricArachnid
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.SummonItems.PrehistoricArachnid", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.SummonItems.PrehistoricArachnid.SetDefaults.3067","20 basic damage"},
				});
				#endregion ThoriumMod.Items.SummonItems.PrehistoricArachnid


				#region ThoriumMod.Items.Misc.LilGuppy
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Misc.LilGuppy", "AnglerQuestChat", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Misc.LilGuppy.AnglerQuestChat.3117","Being out at sea for so long was pretty lonely... I made one friend though, a tiny little fish I named Lil' Guppy! He always manages to escape his fish bowl though! I miss him and I want him, go get my friend!"},
					{"ThoriumMod.ThoriumMod.Items.Misc.LilGuppy.AnglerQuestChat.3118","Caught in the Ocean."},
				});
				#endregion ThoriumMod.Items.Misc.LilGuppy


				#region ThoriumMod.Items.MeleeItems.WrithingSheath
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.MeleeItems.WrithingSheath", "SafeSetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.MeleeItems.WrithingSheath.SafeSetDefaults.3129","200% basic damage"},
				});
				#endregion ThoriumMod.Items.MeleeItems.WrithingSheath


				#region ThoriumMod.Items.HealerItems.BloomingWand
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.BloomingWand", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.BloomingWand.ModifyTooltips.3153","Heals ("},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.BloomingWand.ModifyTooltips.3154",") ally life over 5 seconds"},
				});
				#endregion ThoriumMod.Items.HealerItems.BloomingWand


				#region ThoriumMod.Items.HealerItems.DarkHeart
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.DarkHeart", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.DarkHeart.SetDefaults.3157","40 basic damage"},
				});
				#endregion ThoriumMod.Items.HealerItems.DarkHeart


				#region ThoriumMod.Items.HealerItems.GraniteIonStaff
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.GraniteIonStaff", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.GraniteIonStaff.ModifyTooltips.3163","Shields ally life by "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.GraniteIonStaff.ModifyTooltips.3164"," up to 50"},
				});
				#endregion ThoriumMod.Items.HealerItems.GraniteIonStaff


				#region ThoriumMod.Items.HealerItems.LargePopcorn
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.LargePopcorn", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.LargePopcorn.ModifyTooltips.3168","Heals ally and player life by 1"},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.LargePopcorn.ModifyTooltips.3169","Throws out ("},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.LargePopcorn.ModifyTooltips.3170",") eatable popcorn kernels"},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.LargePopcorn.ModifyTooltips.3171","Up to ("},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.LargePopcorn.ModifyTooltips.3172",") kernels may be out at once"},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.LargePopcorn.ModifyTooltips.3173","Popcorn does not apply on heal effects when consumed"},
				});
				#endregion ThoriumMod.Items.HealerItems.LargePopcorn


				#region ThoriumMod.Items.HealerItems.NecroticStaff
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.NecroticStaff", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.NecroticStaff.ModifyTooltips.3184","Uses 2.5% of your maximum life"},
				});
				#endregion ThoriumMod.Items.HealerItems.NecroticStaff


				#region ThoriumMod.Items.HealerItems.Recuperate
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.Recuperate", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.Recuperate.ModifyTooltips.3194","Channel the tome, turning "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.Recuperate.ModifyTooltips.3195"," mana into "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.Recuperate.ModifyTooltips.3196"," life every second"},
				});
				#endregion ThoriumMod.Items.HealerItems.Recuperate


				#region ThoriumMod.Items.HealerItems.Renew
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.Renew", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.Renew.ModifyTooltips.3199","Instantly recovers "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.Renew.ModifyTooltips.3200"," life"},
				});
				#endregion ThoriumMod.Items.HealerItems.Renew


				#region ThoriumMod.Items.HealerItems.RodofAesculapius
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.RodofAesculapius", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.RodofAesculapius.ModifyTooltips.3203","Heals ally life by "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.RodofAesculapius.ModifyTooltips.3204"," every second"},
				});
				#endregion ThoriumMod.Items.HealerItems.RodofAesculapius


				#region ThoriumMod.Items.HealerItems.SnackLantern
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.SnackLantern", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.SnackLantern.ModifyTooltips.3215","After popping, all nearby allies are healed by [c/5aff5a:"},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.SnackLantern.ModifyTooltips.3216","] life"},
				});
				#endregion ThoriumMod.Items.HealerItems.SnackLantern


				#region ThoriumMod.Items.HealerItems.TwilightStaff
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.TwilightStaff", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.TwilightStaff.ModifyTooltips.3218","Uses "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.TwilightStaff.ModifyTooltips.3219"," mana & "},
					{"ThoriumMod.ThoriumMod.Items.HealerItems.TwilightStaff.ModifyTooltips.3220"," life"},
				});
				#endregion ThoriumMod.Items.HealerItems.TwilightStaff


				#region ThoriumMod.Items.HealerItems.WarForger
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.WarForger", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.HealerItems.WarForger.ModifyTooltips.3226"," up to 25"},
				});
				#endregion ThoriumMod.Items.HealerItems.WarForger


				#region ThoriumMod.Items.Donate.DarkGate
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.DarkGate", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.DarkGate.ModifyTooltips.3269","The gateways can only be used by players every "},
					{"ThoriumMod.ThoriumMod.Items.Donate.DarkGate.ModifyTooltips.3270"," second(s)"},
				});
				#endregion ThoriumMod.Items.Donate.DarkGate


				#region ThoriumMod.Items.Donate.DreamMegaphone
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.DreamMegaphone", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.DreamMegaphone.ModifyTooltips.3277","Increases the damage of all nearby allies by 20% for [c/5aff5a:"},
					{"ThoriumMod.ThoriumMod.Items.Donate.DreamMegaphone.ModifyTooltips.3278","] seconds"},
				});
				#endregion ThoriumMod.Items.Donate.DreamMegaphone


				#region ThoriumMod.Items.Donate.HeartOfTheJungle
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.HeartOfTheJungle", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.HeartOfTheJungle.SetDefaults.3295","40 basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.HeartOfTheJungle


				#region ThoriumMod.Items.Donate.HolyHammer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.HolyHammer", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.HolyHammer.ModifyTooltips.3300","Right click to heal all nearby allies equal to your bonus healing"},
					{"ThoriumMod.ThoriumMod.Items.Donate.HolyHammer.ModifyTooltips.3301","Right click to heal all nearby allies by "},
					{"ThoriumMod.ThoriumMod.Items.Donate.HolyHammer.ModifyTooltips.3303","Right click to heal all nearby allies by 4 life (Max)"},
				});
				#endregion ThoriumMod.Items.Donate.HolyHammer


				#region ThoriumMod.Items.Donate.InfernoLordsFocus
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.InfernoLordsFocus", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.InfernoLordsFocus.SetDefaults.3304","15% basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.InfernoLordsFocus


				#region ThoriumMod.Items.Donate.JetstreamSheath
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.JetstreamSheath", "SafeSetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.JetstreamSheath.SafeSetDefaults.3305","% basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.JetstreamSheath


				#region ThoriumMod.Items.Donate.LadyLight
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.LadyLight", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.LadyLight.ModifyTooltips.3308","5% critical strike chance"},
				});
				#endregion ThoriumMod.Items.Donate.LadyLight


				#region ThoriumMod.Items.Donate.LihzahrdTail
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.LihzahrdTail", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.LihzahrdTail.SetDefaults.3310","30 basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.LihzahrdTail


				#region ThoriumMod.Items.Donate.PlagueLordFlask
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.PlagueLordFlask", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.PlagueLordFlask.SetDefaults.3321","100% basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.PlagueLordFlask


				#region ThoriumMod.Items.Donate.PocketFusionGenerator
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.PocketFusionGenerator", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.PocketFusionGenerator.SetDefaults.3323","18 basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.PocketFusionGenerator


				#region ThoriumMod.Items.Donate.SandweaversTiara
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SandweaversTiara", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.SandweaversTiara.SetDefaults.3333","50 basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.SandweaversTiara


				#region ThoriumMod.Items.Donate.SerpentShield
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SerpentShield", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.SerpentShield.SetDefaults.3386","50 basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.SerpentShield


				#region ThoriumMod.Items.Donate.ShinobiSigil
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.ShinobiSigil", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.ShinobiSigil.SetDefaults.3387","50% basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.ShinobiSigil


				#region ThoriumMod.Items.Donate.SmitingHammer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SmitingHammer", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.SmitingHammer.ModifyTooltips.3391","Right click to heal all nearby allies equal to the weapon's holy charges at twice the mana cost"},
					{"ThoriumMod.ThoriumMod.Items.Donate.SmitingHammer.ModifyTooltips.3392","Right click to heal all nearby allies by "},
					{"ThoriumMod.ThoriumMod.Items.Donate.SmitingHammer.ModifyTooltips.3394","Right click to heal all nearby allies by 20 life (Max) at twice the mana cost"},
				});
				#endregion ThoriumMod.Items.Donate.SmitingHammer


				#region ThoriumMod.Items.Donate.SweetVengeance
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SweetVengeance", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.SweetVengeance.SetDefaults.3406"," basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.SweetVengeance


				#region ThoriumMod.Items.Donate.YumasPendant
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.YumasPendant", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Donate.YumasPendant.SetDefaults.3419","35 basic damage"},
				});
				#endregion ThoriumMod.Items.Donate.YumasPendant


				#region ThoriumMod.Items.Depths.OceanRetaliation
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Depths.OceanRetaliation", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Depths.OceanRetaliation.SetDefaults.3449","50% basic damage"},
				});
				#endregion ThoriumMod.Items.Depths.OceanRetaliation


				#region ThoriumMod.Items.Depths.SpinyShell
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Depths.SpinyShell", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Depths.SpinyShell.SetDefaults.3450","50% basic damage"},
				});
				#endregion ThoriumMod.Items.Depths.SpinyShell


				#region ThoriumMod.Items.DD.OgreSandal
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.DD.OgreSandal", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.DD.OgreSandal.SetDefaults.3454","50 basic damage"},
				});
				#endregion ThoriumMod.Items.DD.OgreSandal


				#region ThoriumMod.Items.BossStarScouter.OmegaDrive
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossStarScouter.OmegaDrive", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BossStarScouter.OmegaDrive.SetDefaults.3493","20 basic damage"},
				});
				#endregion ThoriumMod.Items.BossStarScouter.OmegaDrive


				#region ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm.SetDefaults.3496","25 basic damage"},
				});
				#endregion ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm


				#region ThoriumMod.Items.BossFallenBeholder.VoidPlanter
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossFallenBeholder.VoidPlanter", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BossFallenBeholder.VoidPlanter.ModifyTooltips.3504","Heals player life equal to ("},
					{"ThoriumMod.ThoriumMod.Items.BossFallenBeholder.VoidPlanter.ModifyTooltips.3505","%) of the last damage they took"},
					{"ThoriumMod.ThoriumMod.Items.BossFallenBeholder.VoidPlanter.ModifyTooltips.3506","Heals player life equal to (50%) of the last damage they took (Max)"},
				});
				#endregion ThoriumMod.Items.BossFallenBeholder.VoidPlanter


				#region ThoriumMod.Items.BasicAccessories.BeeBooties
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.BeeBooties", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.BeeBooties.ModifyTooltips.3510","35 basic damage"},
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.BeeBooties.ModifyTooltips.3511","20 basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.BeeBooties


				#region ThoriumMod.Items.BasicAccessories.CrashBoots
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.CrashBoots", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.CrashBoots.SetDefaults.3512","20 basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.CrashBoots


				#region ThoriumMod.Items.BasicAccessories.CrystalSpearTip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.CrystalSpearTip", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.CrystalSpearTip.SetDefaults.3513","100% basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.CrystalSpearTip


				#region ThoriumMod.Items.BasicAccessories.CursedFlailCore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.CursedFlailCore", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.CursedFlailCore.SetDefaults.3514","65% basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.CursedFlailCore


				#region ThoriumMod.Items.BasicAccessories.IronFlailCore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.IronFlailCore", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.IronFlailCore.SetDefaults.3516","35% basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.IronFlailCore


				#region ThoriumMod.Items.BasicAccessories.MoltenSpearTip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.MoltenSpearTip", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.MoltenSpearTip.SetDefaults.3517","75% basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.MoltenSpearTip


				#region ThoriumMod.Items.BasicAccessories.SilverSpearTip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.SilverSpearTip", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.SilverSpearTip.SetDefaults.3518","50% basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.SilverSpearTip


				#region ThoriumMod.Items.BasicAccessories.SlagStompers
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.SlagStompers", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.SlagStompers.SetDefaults.3519","20 basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.SlagStompers


				#region ThoriumMod.Items.BasicAccessories.VileFlailCore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.VileFlailCore", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BasicAccessories.VileFlailCore.SetDefaults.3520","65% basic damage"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.VileFlailCore


				#region ThoriumMod.Items.BardItems.DissTrack
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.DissTrack", "SetBardDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BardItems.DissTrack.SetBardDefaults.3529","50% basic damage"},
				});
				#endregion ThoriumMod.Items.BardItems.DissTrack


				#region ThoriumMod.Items.BardItems.FullScore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.FullScore", "SetBardDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BardItems.FullScore.SetBardDefaults.3530","25% basic damage"},
				});
				#endregion ThoriumMod.Items.BardItems.FullScore


				#region ThoriumMod.Items.BardItems.KickPetal
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.KickPetal", "SetBardDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BardItems.KickPetal.SetBardDefaults.3541","25 basic damage"},
				});
				#endregion ThoriumMod.Items.BardItems.KickPetal


				#region ThoriumMod.Items.BardItems.MixTape
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.MixTape", "SetBardDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BardItems.MixTape.SetBardDefaults.3544","25% basic damage"},
				});
				#endregion ThoriumMod.Items.BardItems.MixTape


				#region ThoriumMod.Items.BardItems.TerrariumAutoharp
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.TerrariumAutoharp", "BardModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BardItems.TerrariumAutoharp.BardModifyTooltips.3568","Variety I"},
					{"ThoriumMod.ThoriumMod.Items.BardItems.TerrariumAutoharp.BardModifyTooltips.3569","Playing empowers players with bonus:"},
				});
				#endregion ThoriumMod.Items.BardItems.TerrariumAutoharp


				#region ThoriumMod.Items.ThrownItems.BoneGrip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.BoneGrip", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.BoneGrip.ModifyTooltips.3583","Duplicated Items: [c/"},
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.BoneGrip.ModifyTooltips.3585"," item]"},
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.BoneGrip.ModifyTooltips.3586"," item]"},
				});
				#endregion ThoriumMod.Items.ThrownItems.BoneGrip


				#region ThoriumMod.Items.ThrownItems.DeadEyePatch
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.DeadEyePatch", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.DeadEyePatch.SetDefaults.3589","50 basic damage"},
				});
				#endregion ThoriumMod.Items.ThrownItems.DeadEyePatch


				#region ThoriumMod.Items.ThrownItems.MagnetoGrip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.MagnetoGrip", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.MagnetoGrip.ModifyTooltips.3593","Duplicated Items: [c/"},
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.MagnetoGrip.ModifyTooltips.3595"," item]"},
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.MagnetoGrip.ModifyTooltips.3596"," items]"},
				});
				#endregion ThoriumMod.Items.ThrownItems.MagnetoGrip


				#region ThoriumMod.Items.ThrownItems.PaddedGrip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.PaddedGrip", "ModifyTooltips", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.PaddedGrip.ModifyTooltips.3599","Duplicated Items: [c/"},
				});
				#endregion ThoriumMod.Items.ThrownItems.PaddedGrip


				#region ThoriumMod.Items.ThrownItems.PiratesPurse
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.PiratesPurse", "SetDefaults", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.PiratesPurse.SetDefaults.3603","25% basic damage"},
				});
				#endregion ThoriumMod.Items.ThrownItems.PiratesPurse

				//套装效果需求
				#region ThoriumMod.Items.Sandstone.SandStoneHelmet
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Sandstone.SandStoneHelmet", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Sandstone.SandStoneHelmet.UpdateArmorSet.3073","Desert winds have granted you a sandy double jump"},
				});
				#endregion ThoriumMod.Items.Sandstone.SandStoneHelmet


				#region ThoriumMod.Items.Misc.HallowedGuise
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Misc.HallowedGuise", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Misc.HallowedGuise.UpdateArmorSet.3116","Become immune after striking an enemy,\nand increases your maximum technique points by 2"},
				});
				#endregion ThoriumMod.Items.Misc.HallowedGuise


				#region ThoriumMod.Items.Bronze.BronzeHelmet
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Bronze.BronzeHelmet", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.Bronze.BronzeHelmet.UpdateArmorSet.3476","Throwing damage has a 20% chance to unleash a piercing lightning strike"},
				});
				#endregion ThoriumMod.Items.Bronze.BronzeHelmet


				#region ThoriumMod.Items.BossThePrimordials.Aqua.TideTurnersGaze
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossThePrimordials.Aqua.TideTurnersGaze", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BossThePrimordials.Aqua.TideTurnersGaze.UpdateArmorSet.3487","Throwing damage has a 20% chance to unleash aquatic homing daggers all around you"},
				});
				#endregion ThoriumMod.Items.BossThePrimordials.Aqua.TideTurnersGaze


				#region ThoriumMod.Items.BossLich.LichCowl
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossLich.LichCowl", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.BossLich.LichCowl.UpdateArmorSet.3495","Killing an enemy will release a soul fragment\nTouching a soul fragment greatly increases your movement and throwing speed briefly"},
				});
				#endregion ThoriumMod.Items.BossLich.LichCowl


				#region ThoriumMod.Items.ArcaneArmor.FlightMask
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ArcaneArmor.FlightMask", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ArcaneArmor.FlightMask.UpdateArmorSet.3576","You can now briefly fly"},
				});
				#endregion ThoriumMod.Items.ArcaneArmor.FlightMask


				#region ThoriumMod.Items.ThrownItems.FungusHat
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.FungusHat", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.FungusHat.UpdateArmorSet.3590","Damage done against mycelium infected enemies is increased by 10%\nDealing damage to enemies infected with mycelium briefly increases throwing speed by 10%"},
				});
				#endregion ThoriumMod.Items.ThrownItems.FungusHat


				#region ThoriumMod.Items.ThrownItems.PlagueDoctorsMask
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.PlagueDoctorsMask", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.PlagueDoctorsMask.UpdateArmorSet.3604","Your plague gas will linger in the air twice as long and your plague reactions will deal 20% more damage"},
				});
				#endregion ThoriumMod.Items.ThrownItems.PlagueDoctorsMask


				#region ThoriumMod.Items.ThrownItems.ShadeMasterMask
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.ShadeMasterMask", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.ShadeMasterMask.UpdateArmorSet.3611","Up to 50% of the damage you take is staggered over the next 10 seconds"},
				});
				#endregion ThoriumMod.Items.ThrownItems.ShadeMasterMask


				#region ThoriumMod.Items.ThrownItems.WhiteDwarfMask
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.WhiteDwarfMask", "UpdateArmorSet", new ()
				{
					{"ThoriumMod.ThoriumMod.Items.ThrownItems.WhiteDwarfMask.UpdateArmorSet.3627","Critical strikes will unleash ivory flares from the cosmos\nIvory flares deal 0.1% of the hit target's maximum life as damage"},
				});
				#endregion ThoriumMod.Items.ThrownItems.WhiteDwarfMask


				//NPC需求
				#region ThoriumMod.NPCs.HealingDummy
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.HealingDummy", "AI", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.HealingDummy.AI.1994"," life/5 sec"},
				});
				#endregion ThoriumMod.NPCs.HealingDummy


				#region ThoriumMod.NPCs.Blacksmith
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Blacksmith", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1640","Me and "},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1641"," have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose."},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1642","I just witnessed "},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1643"," make a knife out of chocolate that's better than half of my own blades..."},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1644","What does that conman "},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1645"," think he's doing trying to offer his cheap trash he calls 'weapons'? If you want the real deal, you've come to the right place!"},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1646","That brute "},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1647"," is more Barbarian than Tracker! Do you have any idea how many times the oaf asked me to fix that battleaxe of his?!"},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1649","You know all those special weapons you find scattered about the land? I've always wondered just how they were forged in the first place. I'm an old man now, but I've still got a long journey to mastery ahead of me..."},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1650","Every blade's got its place in the world: a signature weapon for a hero, a beloved knife for a chef, or maybe just some gaudy piece of junk hanging from a wall."},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1651","Hey brat, corral some people into helping me out at the forge. Blacksmithing ain't a single-man task, and you'll just end up with second-rate junk if you try going solo!"},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1652","'course I followed you here, brat. I crash-coursed you on how to forge and smith weapons for yourself before you arrived here, I'll be damned if I don't get to sit back and watch the ensuing fireworks."},
					{"ThoriumMod.ThoriumMod.NPCs.Blacksmith.GetChat.1653","Welcome! I'm busy workin' on a commission weapon, if you touch anything, consider it sold!"},
				});
				#endregion ThoriumMod.NPCs.Blacksmith


				#region ThoriumMod.NPCs.Cobbler
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Cobbler", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1693","Can you believe that "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1694"," wanted to throw me a birthday party? I haven't had one in so long!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1695","Oh my... I think "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1696"," might be even older than I am!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1697","Ah, so "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1698"," has been giving you advice this whole time? It's always nice to see a young man appreciate his studies."},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1699","In my younger years, I myself was a hero. But after a bad fall, I've since retired. Perhaps if I had better boots back then I would still be a hero today..."},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1700","Worry not young "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1701","lady."},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1702","man."},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1703"," While the journey may be tough, I have full confidence in your ability!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1704","Having proper footwear is no joke, "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1705",". Always make sure your shoes are polished and ready for adventure!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1706","You can learn a lot by walking a mile in someone else's boots. If only some of these townsfolk would walk a mile in yours, then they could understand..."},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1707","How are you doing, "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.GetChat.1708","? Are you staying safe out there in the wilds?"},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Cobbler", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.OnChatButtonClicked.1711","There we go, "},
					{"ThoriumMod.ThoriumMod.NPCs.Cobbler.OnChatButtonClicked.1712",", good as new. It won't last long, but maybe you'll notice some more spring in your step. Make sure to stay safe out there, hero!"},
				});
				#endregion ThoriumMod.NPCs.Cobbler


				#region ThoriumMod.NPCs.ConfusedZombie
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.ConfusedZombie", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1741","I bet "},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1742"," has a big juicy brain... not that I would wanna... uh... did you need something?"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1743","'s brain would surely taste like candy... Oh uh, hello there!"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1744","I can't remember much about my past life... Chemicals and the like were my passion I think; I only get fragments and pieces of the truth. It's saddening at times..."},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1745","Why am I not like the others...? Oh, I'm sorry, did you need something?"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1746","Most people don't have the stomach to handle the things I sell. The trick is to not have a stomach at all!"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.GetChat.1747","I gotta thank you for letting me stick around. Only coming out at night is pretty boring..."},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.ConfusedZombie", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1750","I just whipped up the perfect recipe to deter bats from bothering you; no more tiny nibbles!"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1751","If this turned out correctly, you'll smell just like a zombie. Hopefully your nights will be a tad more calm!"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1752","Getting this stuff to work underwater was a huge hassle... Either way, hungry fish shouldn't attempt to eat you with this."},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1753","I'll be honest, this is just a bottle of pure liquid calcium. Don't question it, the skeletons surely won't."},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1754","With this nasty concoction, insects will associate your scent with their queen! Neat, huh?"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1755","Looks like you're a bit short on funds. Come back to me when you have a little more coin in your pocket!"},
					{"ThoriumMod.ThoriumMod.NPCs.ConfusedZombie.OnChatButtonClicked.1756","I'm afraid you'll have to give me some more time to prepare the next repellent. This stuff can get pretty complicated..."},
				});
				#endregion ThoriumMod.NPCs.ConfusedZombie


				#region ThoriumMod.NPCs.Cook
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Cook", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1782"," can be a real brat at times, but as long as he keeps providing me with fresh fish, I won't complain."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1783","Cooking for "},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1784"," is no easy task. She simply refuses to eat any form of meat!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1785","The last time "},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1786"," asked me to cook for him, he requested bugs! This truly is a strange place..."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1787","I've got a lot of orders from the other townsfolk right now, make it quick!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1788","How did any of you survive before I arrived? What could you have possibly been eating, dirt?"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1789","I'm stuck with dull knives while you wield weapons of unimaginable power? Give me a break..."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1790","No one should go adventuring on an empty stomach. Eat well, hero!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.GetChat.1791","Supply me with the proper ingredients, and I can make some truly powerful foods for you, hero!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Cook", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1794","Lovely, just enough blueberries for the job! Thanks, and please enjoy, "},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1796","This crisp morel was just asking to be put in a dish. I hope it's to your liking!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1797","Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1798","Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1799","With just the right amount of green, this dish gets real mean. Be careful eating it!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1800","I had to visit a far away land to learn how to make this dish. Hopefully you'll appreciate it!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1801","When I was younger, my mother would always greet me with some mint tea after a long, hard day... I miss the simpler times."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1802","Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1803","Last time I took a bite of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1804","Ah, just what I need to help ripen this cheese! Hopefully this'll offer a little more 'pizazz' to its taste."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1805","I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1806","I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1807","So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1808","I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!"},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1809","Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1810","These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure."},
					{"ThoriumMod.ThoriumMod.NPCs.Cook.OnChatButtonClicked.1811","Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!"},
				});
				#endregion ThoriumMod.NPCs.Cook


				#region ThoriumMod.NPCs.DesertAcolyte
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.DesertAcolyte", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1845"," was interested in dyeing my attire, but his choice of plant dye was 'strange' to say the least."},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1846","Look at "},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1847"," over there! He's got an entire arsenal of guns, is that really safe?"},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1848","We certainly have some strange people around this town, don't we...?"},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1849","You didn't see any giant bird shadows while you were out in the desert, did you?"},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1850","I had originally stopped just to refill my canteen, but you seem like someone who can deal with a real threat!"},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1851","Have you ever heard tale of the Thunder Birds? Legend says they had long protected our world from cataclysmic threats, before a disagreement between them and three individuals led to their disappearance..."},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1852","If you're interested in the secrets of my people, be sure to purchase a 'Blank Technique Scroll'. They offer great power to those that utilize them well..."},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.GetChat.1853","I have seen so much evil in my travels... I only hope someone can put a stop to them!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.DesertAcolyte", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.OnChatButtonClicked.1856","Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however..."},
					{"ThoriumMod.ThoriumMod.NPCs.DesertAcolyte.OnChatButtonClicked.1857","Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please."},
				});
				#endregion ThoriumMod.NPCs.DesertAcolyte


				#region ThoriumMod.NPCs.Diverman
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Diverman", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1885","Visiting that sea rift again wasn't my best idea... that mutant jellyfish almost ate me whole!"},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1886","Yuck... that vile creature almost got away with eating me! Thank you for saving me, hero."},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1887","Have you adventured into the aquatic depths yet...? Its choking atmosphere prevents most explorers from entering, but I'm confident you'll find a way around it..."},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1888","I've collected many marine items in my travels, hero. Would you like to purchase one?"},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1889","Being at the bottom of the ocean for long periods of time has taught me one thing; Always come prepared!"},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1890","You would think it gets hard to breath under this helmet, but really I'm just used to it now."},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.GetChat.1891","You ever try to drink a bottle of water, while drowning, to save yourself? I know I have!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Diverman", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.OnChatButtonClicked.1894","Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!"},
					{"ThoriumMod.ThoriumMod.NPCs.Diverman.OnChatButtonClicked.1895","Hmm, your air tank looks full to me... Did you just want to chat? I have all manner of tales to tell!"},
				});
				#endregion ThoriumMod.NPCs.Diverman


				#region ThoriumMod.NPCs.Druid
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Druid", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1922","Our friend there, "},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1923",", is rather strange isn't he? He speaks in riddles..."},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1924","I wonder if I can convince "},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1925"," to whip me up a salad."},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1928","Gathering seeds is a bigger hassle than you would think. Nearly drowning, almost melting, freezing to- You get the idea."},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1929","I often take visits to the jungle. I can understand the aversion to the place, but the creatures within don't seem to hassle me..."},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1930","My mother was a well known herbalist back in the day. She doesn't talk about my father, though. I wonder why?"},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1931","How does today find you, "},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1932","? Make sure to stop and smell the roses!"},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1933","Even a small seed can grow into a mighty oak! Keep that in mind, "},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1935","Defeating powerful monsters will make it safer for me to venture into different biomes in search of seeds. Check back with me regularly, "},
					{"ThoriumMod.ThoriumMod.NPCs.Druid.GetChat.1937","The natural world is quite a wonder. Every little place has its own charm. Some more than others!"},
				});
				#endregion ThoriumMod.NPCs.Druid


				#region ThoriumMod.NPCs.PeculiarMirror
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.PeculiarMirror", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.PeculiarMirror.GetChat.2035","Before you sits a rather strange mirror. Something seems to be calling out from it...?"},
				});
				#endregion ThoriumMod.NPCs.PeculiarMirror


				#region ThoriumMod.NPCs.Spiritualist
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Spiritualist", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2076","Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long..."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2077"," often comes to me in private to discuss things that are bothering him. Such a young age to be in his position..."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2078","Beware my friend... true evil walks among us this night."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2079","Ah, it's been a while friend. It is good to see you are well after so long!"},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2080","Whether in body, mind, or spirit, always consider how you may grow today, my friend."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2081","Energy, chi, spirit... it's all the same to me. There is power in all things."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2082","I have no doubt of your physical power, hero. But sometimes hardship is fought in a battle of will, not strength."},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Spiritualist", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.OnChatButtonClicked.2085","I'm afraid I can't currently protect you, friend. Give your soul some time to heal, and then come speak to me again."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.OnChatButtonClicked.2086","With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.OnChatButtonClicked.2087","I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire 5, come visit me again."},
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.OnChatButtonClicked.2088","No need to fear my friend, my power is already protecting you. Come back when my power has faded."},
				});
				#endregion ThoriumMod.NPCs.Spiritualist


				#region ThoriumMod.NPCs.ThoriumGlobalNPC
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.ThoriumGlobalNPC", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2108","Ah, a "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2109","woman of music!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2110","man of music!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2111"," How well can you carry a tune?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2112","You know, people would pay good money for quality music like yours. Care to hear my business proposition...?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2113","In my younger years I was quite the experienced bard too! I've since left that behind me, though."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2114","Are you sure you really need my help healing you and your allies? You seem to have it under control..."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2115","Another healer in town? Ugh, this will be bad for business..."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2116","Say, if you're going to explore the dungeon, keep an eye out for this bizarre mirror. I only caught a glance at it while tied up, but it gave me serious heebie-jeebies..."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2117","How I got kidnapped in the first place? One of their guys had crazy illusion magic, had me convinced I was being brought in to help install some new lighting!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2118","Aye, so the legends be true... A great and terrible beast lurks beneath the depths, matey. Best if you go and handle it, eh?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2119","Aye, I once saw a sea demon risin' from those depths. Somethin' dark, somethin' ancient, somethin'... uhh... You gonna buy somethin'?!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2120","Got a special deal for ya, straight from this poor lot who wandered into that old Bat's lair unprepared."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2121","You see lots when you wander these caverns, y'know? Other day I stumbled upon this chamber absolutely drenched in blood! Sight shook me to my bones, I'll tell you what!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2125","Yeah, yeah, everyone's going crazy over your 'saving the world' thing. But have you saved the 200 fancy fish I've asked for? If not then it's back to work, minion!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2126","'Ocean Essences', huh? Do you think if I have enough, I'll become the Supreme God-Emperor of all Fishkind?! I've got a new quest for you, Supreme Helper Minion! Get for me 100 MILLION of those Ocean thingies, pronto!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2127","Peace is all fine and dandy, but what am I supposed to use as target practice now?!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2128","Heh, I told you from day one, brat: I came here to watch the fireworks, and you sure delivered."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2129","Ever since you freed me from my curse, I figured you were tailor-made for this whole hero business."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2130","I can't believe it, never in a million years... But look at you, standing so triumphantly! Ha ha hah! Congratulations, but more importantly: thank you, from the bottom of my heart, hero. Thanks to your incredible bravery, an old friend of mine can rest easy now..."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2131","I barely remember anything from before I died, but that doesn't mean I can't make new memories. I'll be sure to remember your victory for as long as this body can move!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2132","I could see the battle from here. To think you would risk your life to save us from something as overwhelming as... that. Take a seat kid, I'll cook your favorite meal - it's on me."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2133","Simply incredible. I had calculated your odds of survival at less than 0.001% against those creatures and yet here you stand. Truly the will of man is a thing of wonder."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2134","What a series of fireworks that purple guy let out! Can't help but take it as a challenge; one pyrotechnics show that'll blow your socks off, comin' right up!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2135","It seems I was right to place my trust in you, my friend. You've protected us from every threat that arose, and for that, I'm truly grateful. Maybe now I can finally relax a little."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2136","Not bad, kid... Not bad at all. Hopefully you've had fun during all of your adventures out there. I guess you could say I've always been keeping an eye on you."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2137","Normally I'd say something like, 'nature finds a way', but I'm not even sure if Mother Nature could survive if you failed to stop those spirits' carnage... Please take these lilies, in gratitude for your courage!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2138","To think a threat even more dangerous than the Moon Lord existed out there... It makes me wonder what else lies beyond what we see. Let's not worry about that for now though, "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2139",", we should celebrate your victory!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2140","Ah... must you keep that crown above your head, darling? The colors are rich, but its aesthetic is... garish."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2141","I thought for sure we were all doomed when those creatures emerged so I jumped the gun on a confession of mine. It ended up working out though, so maybe I'm glad we almost all died!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2142","I'd say that battle looked like a hole in one to me, "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2143",". Maybe you can finally relax after all that ceaseless fighting and play some golf with me; What do you say?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2144","Congratulations on your victory! I'm sure you've already noticed, but each of the primordial spirits left behind part of their essence over the domain they control after you defeated them. They're as powerful as they sound, and you can make some extremely potent gear with them. As always, I can help you see what you can craft with them!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2145","It seems like things are gonna be a lot more peaceful from here on out. Maybe now I can finally focus on my machines... and maybe someone special to me."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2146","Amazing work, friend! I sold off all my 'end of the world' merchandise, and now thanks to you, I can actually live long enough to kick back and enjoy the benefits!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2147","I assume that you won't be having too many injuries from here on out? Shame, there goes my greatest money maker."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2148","I see you're quite the curious person... Thought I might say something interesting, hm? Well savor your victory for now. Our true master will return one day, and when he does, this world will know death once more."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2149","Not another word, "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2150","! I'm already starting my newest masterpiece: a capturing of your stupendous battle!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2151","That crown! Does that mean you're now the "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2152","QUEEN"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2153","KING"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2154"," OF THE UNIVERSE?! Do you know what this calls for?! The greatest coronation party EVER!!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2155","Best be reckonin' that travelin' the seven seas will be smoother sailin' than a newborn's behind now that the Lady High Tide has been quell'd... And prob'ly high time for this ol' swashbuckler to set voyage for a new adventure!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2156","Thank you, "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2157",", from the bottom of my heart. It's thanks to you that my subjects and I can enjoy peace and prosperity once more. You're my knight in shining armor!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2158","If saving the world doesn't make you a good "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2159","girl"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2160","boy"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2161",", then I don't know what does. No coal for you this year!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2162","Take a gander at that crown above your head! Just which poor sap did you nab that from?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2163","From the moment we first spoke I sensed something special within you. Your spirit exudes an incredible energy, one that I'm honored to have witnessed. Stay golden my friend."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2164","An endless source of fire and water fell from those creatures you say? Oy, that sounds like a great way to generate some steam!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2165","Wasn't aware the primordial forces of Terraria had a sense of humor. 'I saved the world and all I got was this gaudy crown' and all that, right hun?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2166","Well now. Even back in Etheria I haven't seen a hero defend their home with such bravery and tenacity before. Maybe you do measure up after all."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2167","I see that fancy crown above your head, alright. Bah! You already acted like a despot, now you have the looks to back it up. Just separate me from my lovely gold and leave!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2168","A reality-ending nightmare entity, kid? You certainly don't cut corners, there's no way I can top that!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2169","Hey, I'm back in town! Did I miss anything exciting...?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2170","I would have never seen the things I've seen recently if I had stayed underground, so thank you for that wonderful - and totally not at all terrifying - show!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2171","I was exiled from my people when I chose to side with your kind. They thought me foolish, placing faith in those that dwelled above. I'm sure they're feeling rather foolish themselves after what you've just accomplished. Well done, "},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2173","Heroism inspires legends, legends inspire heroism."},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2174","Everyone is quite lively right now! I'm so glad all of you remembered that today was my birthday!"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2175","Okay, like, wait. One more time. You say there were three of them? Okay yeah, and what did they look like exactly? Like, for real? This bestiary entry is gonna really test my drawing skills, huh?"},
					{"ThoriumMod.ThoriumMod.NPCs.ThoriumGlobalNPC.GetChat.2176","I see you've got yourself an instrument. Instruments use ‘inspiration’ to provide helpful buffs to you and your team, as well as damage enemies. You’ll need Inspiration Fragments to increase your maximum inspiration, which can be crafted from fallen stars and a strange ore underground! Who knows, maybe later on you can increase it even more with other unique materials..."},
				});
				#endregion ThoriumMod.NPCs.ThoriumGlobalNPC


				#region ThoriumMod.NPCs.Tracker
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Tracker", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2203","Do you think "},
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2204"," would give a haircut even to a brute like me...?"},
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2206",", and I were gonna start a gym together. You want in?"},
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2207","Seen any interesting beasts lurking around lately? Minotaurs? Beholders? Gorgons?"},
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2208","Bear your scars with pride, as each one has a tale to tell... What do your scars say about you, hero?"},
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2209","Many beasts have fallen to me and my axe, but new ones are always on the prowl. Keep your eyes peeled, kid."},
					{"ThoriumMod.ThoriumMod.NPCs.Tracker.GetChat.2210","You'd be surprised how effective a single shoulder pad can be."},
				});
				#endregion ThoriumMod.NPCs.Tracker


				#region ThoriumMod.NPCs.WeaponMaster
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.WeaponMaster", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2243"," blankly stares through you, as though he's not entirely there..."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2244"," keeps giving me dirty looks... It's not like I carry a doll myself."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2245","*So... you've gained the ability to speak in tongues, "},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2246","? Very fascinating...*"},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2249","Long ago, when this world was first taking form, my race reigned supreme. That time has passed it seems..."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2250","I'm not one for idle chatter. If you have need of me, make it quick."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2251","My race's obsession with voodoo dolls has only become rampant just recently. It's truly a fad gone wrong..."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2252","Should you have the coin, I would be willing to accompany you in your endeavors..."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.GetChat.2253","A warrior without his weapon stands no chance against the ever-powering threats he must face..."},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.WeaponMaster", "OnChatButtonClicked", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.OnChatButtonClicked.2256"," blankly stares through you, as though he's not entirely there..."},
					{"ThoriumMod.ThoriumMod.NPCs.WeaponMaster.OnChatButtonClicked.2257","I see you're lacking in coin. Remedy that and I may just help you out..."},
				});
				#endregion ThoriumMod.NPCs.WeaponMaster


			}
		}
	}
}
