using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
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
				#region ThoriumMod.ThoriumPlayer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.ThoriumPlayer", "AddCoinTooltip", new()
				{
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.167"," gold, "},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.168"," gold, and "},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.169"," silver, and "},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.170"," silver"},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.171"," copper"},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.172","0 coins"},
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.AddCoinTooltip.176","MoneyAmount"},
				});
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.ThoriumPlayer", "PostUpdateEquips", new ()
				{
					{"ThoriumMod.ThoriumMod.ThoriumPlayer.PostUpdateEquips.142"," life heal streak"},
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


				#region ThoriumMod.NPCs.HealingDummy
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.HealingDummy", "AI", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.HealingDummy.AI.1994"," life/5 sec"},
				});
				#endregion ThoriumMod.NPCs.HealingDummy


				#region ThoriumMod.NPCs.Spiritualist
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.NPCs.Spiritualist", "GetChat", new ()
				{
					{"ThoriumMod.ThoriumMod.NPCs.Spiritualist.GetChat.2080","Whether in body, mind, or spirit, always consider how you may grow today, my friend."},
				});
				#endregion ThoriumMod.NPCs.Spiritualist


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


			}
		}
	}
}
