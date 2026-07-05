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
				#region RagnarokMod.Items.HealerItems.Armor.IntergelacticRamhelm
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Items.HealerItems.Armor.IntergelacticRamhelm", "UpdateArmorSet", new ()
				{
					{"\n星环击中敌怪有 5% 的概率掉落一颗红心。\n按下“盔甲能力”键消耗星环恢复 50 点生命值并获得 100 点生命护盾。","\nHitting an enemy with an asteroid has an 5% chance to drop a heart\nPressing the 'Armor Ability' key will use up the asteroids to replenish 50 health and grants you a lifeshield of 100"},
				});
				#endregion RagnarokMod.Items.HealerItems.Armor.IntergelacticRamhelm


				#region RagnarokMod.Items.BardItems.Armor.IntergelacticRobohelm
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Items.BardItems.Armor.IntergelacticRobohelm", "UpdateArmorSet", new ()
				{
					{"\n星环击中敌怪有5%概率提供随机1-3级咒音增幅。\n按下“盔甲能力”会消耗星环恢复100点灵感值，并触发所有4级资源型咒音增幅。","\nHitting an enemy with an asteroid has an 5% chance to apply a random empowerment on level 1 to 3\nPressing the 'Armor Ability' key will exhaust the asteroids to replenish 100 inspiration and apply all resource empowerments on level 4"},
					{"\n星环的力量已耗尽","\nThe power of your asteroids is currently exhausted"},
				});
				#endregion RagnarokMod.Items.BardItems.Armor.IntergelacticRobohelm


				#region RagnarokMod.Common.ModSystems.OtherModsCompat
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Common.ModSystems.OtherModsCompat", "ApplyRagnarokTBRBossChanges", new ()
				{
					{"诸神的黄昏报错: 读取和修改【瑟银冥界】设置失败。自动退回之前设置。","Ragnarok Error: Failed to read and modify TBReworked config. Fallback to Auto config"},
				});
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Common.ModSystems.OtherModsCompat", "RemoveOwnRecipe", new ()
				{
					{"诸神的黄昏报错：无法删除自身配方。","Ragnarok Error: Failed to remove own recipe."},
				});
				#endregion RagnarokMod.Common.ModSystems.OtherModsCompat


				#region RagnarokMod.Common.GlobalItems.TweakToolTips
				TranslatorLoad.LocalizeByTypeFullName("RagnarokMod.Common.GlobalItems.TweakToolTips", "ModifyTooltips", new ()
				{
					{"\n增加2点最大灵感值和2点额外治疗量","\nIncreases maximum inspiration by 2 and heal bonus by 2"},
				});
				#endregion RagnarokMod.Common.GlobalItems.TweakToolTips


			}
		}
	}
}

