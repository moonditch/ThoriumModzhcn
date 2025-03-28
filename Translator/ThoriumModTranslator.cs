using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.Translator
{
	public class ThoriumModTranslator
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystemTiger<ThoriumMod, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				#region ThoriumMod.ThoriumPlayer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.ThoriumPlayer", "AddCoinTooltip", new ()
				{
					{" gold, ","金币"},
					{" gold, and ","金币和"},
					{" silver, and ","银币和"},
					{" silver","银币"},
					{" copper","铜币"},
					{"0 coins","0 钱币"},
					{"Money Generated: ","额外掉落钱币: "},
				});
				#endregion ThoriumMod.ThoriumPlayer


				#region ThoriumMod.Items.ThoriumGlobalItem
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThoriumGlobalItem", "AddCookText", new ()
				{
					{"The cook might be interested in this: ","厨师可能对此感兴趣"},
				});
				#endregion ThoriumMod.Items.ThoriumGlobalItem


				#region ThoriumMod.Items.ThoriumItem
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThoriumItem", "ModifyTooltips", new ()
				{
					{"-Reality Breaker-","-现实破坏者-"},
					{"-Transformation-","-化形-"},
					{"-Thrower Class-","-投手职业-"},
					{"-Healer Class-","-牧师职业-"},
					{"Grants ","直接命中会获得"},
					{" soul essence on direct hit","层灵魂精华"},
					{" & ","和"},
					{" life","生命值"},
					{" by "," "},
					{" equal to your bonus healing","等同于治疗加成的生命值"},
				});
				#endregion ThoriumMod.Items.ThoriumItem


				#region ThoriumMod.Items.ZRemoved.StonePurple
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ZRemoved.StonePurple", "ModifyTooltips", new ()
				{
					{"1% of targets health as true damage","1%目标最大生命值的真实伤害"},
				});
				#endregion ThoriumMod.Items.ZRemoved.StonePurple


				#region ThoriumMod.Items.TransformItems.SoulLink
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.TransformItems.SoulLink", "ModifyTooltips", new ()
				{
					{"-Early Testing-","-早期测试物品-"},
					{"Allows you to use unique abilities while transformed","允许你在化形时使用独特的能力"},
				});
				#endregion ThoriumMod.Items.TransformItems.SoulLink


				#region ThoriumMod.Items.Thorium.Crietz
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Thorium.Crietz", "SetDefaults", new ()
				{
					{"15 basic damage","15 基本伤害"},
				});
				#endregion ThoriumMod.Items.Thorium.Crietz


				#region ThoriumMod.Items.SummonItems.CrystalScorpion
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.SummonItems.CrystalScorpion", "SetDefaults", new ()
				{
					{"25 basic damage","25 基本伤害"},
				});
				#endregion ThoriumMod.Items.SummonItems.CrystalScorpion


				#region ThoriumMod.Items.SummonItems.IncubatedEgg
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.SummonItems.IncubatedEgg", "SetDefaults", new ()
				{
					{"14 basic damage","14 基本伤害"},
				});
				#endregion ThoriumMod.Items.SummonItems.IncubatedEgg


				#region ThoriumMod.Items.SummonItems.PrehistoricArachnid
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.SummonItems.PrehistoricArachnid", "SetDefaults", new ()
				{
					{"20 basic damage","20 基本伤害"},
				});
				#endregion ThoriumMod.Items.SummonItems.PrehistoricArachnid


				#region ThoriumMod.Items.MeleeItems.WrithingSheath
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.MeleeItems.WrithingSheath", "SafeSetDefaults", new ()
				{
					{"200% basic damage","200% 基本伤害"},
				});
				#endregion ThoriumMod.Items.MeleeItems.WrithingSheath


				#region ThoriumMod.Items.HealerItems.BloomingWand
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.BloomingWand", "ModifyTooltips", new ()
				{
					{"Heals (","在5秒内治疗("},
					{") ally life over 5 seconds",")点队友生命"},
				});
				#endregion ThoriumMod.Items.HealerItems.BloomingWand


				#region ThoriumMod.Items.HealerItems.DarkHeart
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.DarkHeart", "SetDefaults", new ()
				{
					{"40 basic damage","40 基本伤害"},
				});
				#endregion ThoriumMod.Items.HealerItems.DarkHeart


				#region ThoriumMod.Items.HealerItems.GraniteIonStaff
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.GraniteIonStaff", "ModifyTooltips", new ()
				{
					{"Shields ally life by ","为队友施加"},
					{" up to 50","点生命护盾，至多50点"},
				});
				#endregion ThoriumMod.Items.HealerItems.GraniteIonStaff


				#region ThoriumMod.Items.HealerItems.LargePopcorn
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.LargePopcorn", "ModifyTooltips", new ()
				{
					{"Heals ally and player life by 1","治疗队友和玩家1点生命值"},
					{"Throws out (","扔出("},
					{") eatable popcorn kernels",")个可食用的爆米花粒"},
					{"Up to (","同时可以扔出至多("},
					{") kernels may be out at once",")个爆米花粒"},
					{"Popcorn does not apply on heal effects when consumed","爆米花消耗时不会施加治疗效果"},
				});
				#endregion ThoriumMod.Items.HealerItems.LargePopcorn


				#region ThoriumMod.Items.HealerItems.NecroticStaff
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.NecroticStaff", "ModifyTooltips", new ()
				{
					{"Uses 2.5% of your maximum life","消耗自身2.5%最大生命值"},
				});
				#endregion ThoriumMod.Items.HealerItems.NecroticStaff


				#region ThoriumMod.Items.HealerItems.Recuperate
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.Recuperate", "ModifyTooltips", new ()
				{
					{"Channel the tome, turning ","持续使用法术书，每秒将"},
					{" mana into ","魔力转化为"},
					{" life every second","生命值"},
				});
				#endregion ThoriumMod.Items.HealerItems.Recuperate


				#region ThoriumMod.Items.HealerItems.Renew
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.Renew", "ModifyTooltips", new ()
				{
					{"Instantly recovers ","立刻恢复"},
					{" life","生命值"},
				});
				#endregion ThoriumMod.Items.HealerItems.Renew


				#region ThoriumMod.Items.HealerItems.RodofAesculapius
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.RodofAesculapius", "ModifyTooltips", new ()
				{
					{"Heals ally life by ","每秒治疗队友"},
					{" every second","生命值"},
				});
				#endregion ThoriumMod.Items.HealerItems.RodofAesculapius


				#region ThoriumMod.Items.HealerItems.SnackLantern
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.SnackLantern", "ModifyTooltips", new ()
				{
					{"After popping, all nearby allies are healed by [c/5aff5a:","爆炸后治疗附近所有队友[c/5aff5a:"},
					{"] life","] 生命值"},
				});
				#endregion ThoriumMod.Items.HealerItems.SnackLantern


				#region ThoriumMod.Items.HealerItems.TwilightStaff
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.TwilightStaff", "ModifyTooltips", new ()
				{
					{"Uses ","使用"},
					{" mana & ","魔力和"},
					{" life","生命值"},
				});
				#endregion ThoriumMod.Items.HealerItems.TwilightStaff


				#region ThoriumMod.Items.HealerItems.WarForger
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.WarForger", "ModifyTooltips", new ()
				{
					{" up to 25","点生命护盾，至多25点"},
				});
				#endregion ThoriumMod.Items.HealerItems.WarForger


				#region ThoriumMod.Items.Donate.BlastShield
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.BlastShield", "ModifyTooltips", new ()
				{
					{" base damage","基础伤害"},
				});
				#endregion ThoriumMod.Items.Donate.BlastShield


				#region ThoriumMod.Items.Donate.DarkGate
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.DarkGate", "ModifyTooltips", new ()
				{
					{"The gateways can only be used by players every ","传送门只能每过"},
					{" second(s)","秒使用"},
				});
				#endregion ThoriumMod.Items.Donate.DarkGate


				#region ThoriumMod.Items.Donate.DreamMegaphone
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.DreamMegaphone", "ModifyTooltips", new ()
				{
					{"Increases the damage of all nearby allies by 20% for [c/5aff5a:","增加附近所有队友20%伤害，持续 [c/5aff5a:"},
					{"] seconds","] 秒"},
				});
				#endregion ThoriumMod.Items.Donate.DreamMegaphone


				#region ThoriumMod.Items.Donate.HeartOfTheJungle
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.HeartOfTheJungle", "SetDefaults", new ()
				{
					{"40 basic damage","40 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.HeartOfTheJungle


				#region ThoriumMod.Items.Donate.HolyHammer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.HolyHammer", "ModifyTooltips", new ()
				{
					{"Right click to heal all nearby allies equal to your bonus healing","右键单击治疗附近所有队友，治疗量等于治疗加成"},
					{"Right click to heal all nearby allies by ","右键单击治疗附近所有队友"},
					{"Right click to heal all nearby allies by 4 life (Max)","右键单击治疗附近所有队友4点生命值(max)"},
				});
				#endregion ThoriumMod.Items.Donate.HolyHammer


				#region ThoriumMod.Items.Donate.InfernoLordsFocus
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.InfernoLordsFocus", "SetDefaults", new ()
				{
					{"15% basic damage","15% 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.InfernoLordsFocus


				#region ThoriumMod.Items.Donate.JetstreamSheath
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.JetstreamSheath", "SafeSetDefaults", new ()
				{
					{"% basic damage","% 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.JetstreamSheath


				#region ThoriumMod.Items.Donate.LadyLight
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.LadyLight", "ModifyTooltips", new ()
				{
					{"5% critical strike chance","5%暴击率"},
				});
				#endregion ThoriumMod.Items.Donate.LadyLight


				#region ThoriumMod.Items.Donate.LihzahrdTail
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.LihzahrdTail", "SetDefaults", new ()
				{
					{"30 basic damage","30 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.LihzahrdTail


				#region ThoriumMod.Items.Donate.PlagueLordFlask
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.PlagueLordFlask", "SetDefaults", new ()
				{
					{"100% basic damage","100% 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.PlagueLordFlask


				#region ThoriumMod.Items.Donate.PocketFusionGenerator
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.PocketFusionGenerator", "SetDefaults", new ()
				{
					{"18 basic damage","18 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.PocketFusionGenerator


				#region ThoriumMod.Items.Donate.SandweaversTiara
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SandweaversTiara", "SetDefaults", new ()
				{
					{"50 basic damage","50 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.SandweaversTiara


				#region ThoriumMod.Items.Donate.SerpentShield
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SerpentShield", "SetDefaults", new ()
				{
					{"50 basic damage","50 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.SerpentShield


				#region ThoriumMod.Items.Donate.ShinobiSigil
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.ShinobiSigil", "SetDefaults", new ()
				{
					{"50% basic damage","50% 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.ShinobiSigil


				#region ThoriumMod.Items.Donate.SmitingHammer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SmitingHammer", "ModifyTooltips", new ()
				{
					{"Right click to heal all nearby allies equal to the weapon's holy charges at twice the mana cost","右键以两倍的法力消耗治疗附近队友，治疗量等同于该武器的神圣充能。"},
					{"Right click to heal all nearby allies by ","右键单击治疗附近所有队友"},
					{"Right click to heal all nearby allies by 20 life (Max) at twice the mana cost","右键单击治疗附近所有队友20点生命值(max)两倍的魔力消耗"},
				});
				#endregion ThoriumMod.Items.Donate.SmitingHammer


				#region ThoriumMod.Items.Donate.SweetVengeance
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SweetVengeance", "SetDefaults", new ()
				{
					{" basic damage","基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.SweetVengeance


				#region ThoriumMod.Items.Donate.YumasPendant
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.YumasPendant", "SetDefaults", new ()
				{
					{"35 basic damage","35 基本伤害"},
				});
				#endregion ThoriumMod.Items.Donate.YumasPendant


				#region ThoriumMod.Items.Depths.OceanRetaliation
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Depths.OceanRetaliation", "SetDefaults", new ()
				{
					{"50% basic damage","50% 基本伤害"},
				});
				#endregion ThoriumMod.Items.Depths.OceanRetaliation


				#region ThoriumMod.Items.Depths.SpinyShell
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Depths.SpinyShell", "SetDefaults", new ()
				{
					{"50% basic damage","50% 基本伤害"},
				});
				#endregion ThoriumMod.Items.Depths.SpinyShell


				#region ThoriumMod.Items.DD.OgreSandal
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.DD.OgreSandal", "SetDefaults", new ()
				{
					{"50 basic damage","50 基本伤害"},
				});
				#endregion ThoriumMod.Items.DD.OgreSandal


				#region ThoriumMod.Items.BossStarScouter.OmegaDrive
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossStarScouter.OmegaDrive", "SetDefaults", new ()
				{
					{"20 basic damage","20 基本伤害"},
				});
				#endregion ThoriumMod.Items.BossStarScouter.OmegaDrive


				#region ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm", "SetDefaults", new ()
				{
					{"25 basic damage","25 基本伤害"},
				});
				#endregion ThoriumMod.Items.BossGraniteEnergyStorm.EyeoftheStorm


				#region ThoriumMod.Items.BossFallenBeholder.VoidPlanter
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BossFallenBeholder.VoidPlanter", "ModifyTooltips", new ()
				{
					{"Heals player life equal to (","治疗玩家等同于上次受到伤害("},
					{"%) of the last damage they took","%)的生命值"},
					{"Heals player life equal to (50%) of the last damage they took (Max)","治疗玩家等同于上次受到伤害(50%)的生命值 (Max)"},
				});
				#endregion ThoriumMod.Items.BossFallenBeholder.VoidPlanter


				#region ThoriumMod.Items.BasicAccessories.BeeBooties
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.BeeBooties", "ModifyTooltips", new ()
				{
					{"35 basic damage","35 基本伤害"},
					{"20 basic damage","20 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.BeeBooties


				#region ThoriumMod.Items.BasicAccessories.CrashBoots
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.CrashBoots", "SetDefaults", new ()
				{
					{"20 basic damage","20 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.CrashBoots


				#region ThoriumMod.Items.BasicAccessories.CrystalSpearTip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.CrystalSpearTip", "SetDefaults", new ()
				{
					{"100% basic damage","100% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.CrystalSpearTip


				#region ThoriumMod.Items.BasicAccessories.CursedFlailCore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.CursedFlailCore", "SetDefaults", new ()
				{
					{"65% basic damage","65% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.CursedFlailCore


				#region ThoriumMod.Items.BasicAccessories.IronFlailCore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.IronFlailCore", "SetDefaults", new ()
				{
					{"35% basic damage","35% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.IronFlailCore


				#region ThoriumMod.Items.BasicAccessories.MoltenSpearTip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.MoltenSpearTip", "SetDefaults", new ()
				{
					{"75% basic damage","75% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.MoltenSpearTip


				#region ThoriumMod.Items.BasicAccessories.SilverSpearTip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.SilverSpearTip", "SetDefaults", new ()
				{
					{"50% basic damage","50% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.SilverSpearTip


				#region ThoriumMod.Items.BasicAccessories.SlagStompers
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.SlagStompers", "SetDefaults", new ()
				{
					{"20 basic damage","20 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.SlagStompers


				#region ThoriumMod.Items.BasicAccessories.VileFlailCore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.VileFlailCore", "SetDefaults", new ()
				{
					{"65% basic damage","65% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BasicAccessories.VileFlailCore


				#region ThoriumMod.Items.BardItems.DissTrack
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.DissTrack", "SetBardDefaults", new ()
				{
					{"50% basic damage","50% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BardItems.DissTrack


				#region ThoriumMod.Items.BardItems.FullScore
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.FullScore", "SetBardDefaults", new ()
				{
					{"25% basic damage","25% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BardItems.FullScore


				#region ThoriumMod.Items.BardItems.KickPetal
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.KickPetal", "SetBardDefaults", new ()
				{
					{"25 basic damage","25 基本伤害"},
				});
				#endregion ThoriumMod.Items.BardItems.KickPetal


				#region ThoriumMod.Items.BardItems.MixTape
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.MixTape", "SetBardDefaults", new ()
				{
					{"25% basic damage","25% 基本伤害"},
				});
				#endregion ThoriumMod.Items.BardItems.MixTape


				#region ThoriumMod.Items.BardItems.TerrariumAutoharp
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.TerrariumAutoharp", "BardModifyTooltips", new ()
				{
					{"Variety I","多种音波脉冲 I"},
					{"Playing empowers players with bonus:","演奏会提供玩家以下加成"},
				});
				#endregion ThoriumMod.Items.BardItems.TerrariumAutoharp


				#region ThoriumMod.Items.ThrownItems.BoneGrip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.BoneGrip", "ModifyTooltips", new ()
				{
					{"Duplicated Items: [c/","复制物品数量: [c/"},
					{" items]","物品]"},
				});
				#endregion ThoriumMod.Items.ThrownItems.BoneGrip


				#region ThoriumMod.Items.ThrownItems.DeadEyePatch
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.DeadEyePatch", "SetDefaults", new ()
				{
					{"50 basic damage","50 基本伤害"},
				});
				#endregion ThoriumMod.Items.ThrownItems.DeadEyePatch


				#region ThoriumMod.Items.ThrownItems.MagnetoGrip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.MagnetoGrip", "ModifyTooltips", new ()
				{
					{"Duplicated Items: [c/","复制物品数量: [c/"},
					{" items]","物品]"},
				});
				#endregion ThoriumMod.Items.ThrownItems.MagnetoGrip


				#region ThoriumMod.Items.ThrownItems.PaddedGrip
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.PaddedGrip", "ModifyTooltips", new ()
				{
					{"Duplicated Items: [c/","复制物品数量: [c/"},
					{" items]","物品]"},
				});
				#endregion ThoriumMod.Items.ThrownItems.PaddedGrip


				#region ThoriumMod.Items.ThrownItems.PiratesPurse
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThrownItems.PiratesPurse", "SetDefaults", new ()
				{
					{"25% basic damage","20% 基本伤害"},
				});
				#endregion ThoriumMod.Items.ThrownItems.PiratesPurse

				#region ThoriumMod.Items.Misc.LilGuppy
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Misc.LilGuppy", "AnglerQuestChat", new ()
				{
					{"Being out at sea for so long was pretty lonely... I made one friend though, a tiny little fish I named Lil' Guppy! He always manages to escape his fish bowl though! I miss him and I want him, go get my friend!","在海上呆这么长时间是相当孤独的。不过我交了个朋友，它是一条小鱼，我叫它小虹鳉！不过他总是设法从鱼缸里逃出去！我想他，我想要他，快去找我的朋友！"},
					{"Caught in the Ocean.","在海洋生物群系捕捉"},
				});
				#endregion ThoriumMod.Items.Misc.LilGuppy


			}
		}
	}
}
