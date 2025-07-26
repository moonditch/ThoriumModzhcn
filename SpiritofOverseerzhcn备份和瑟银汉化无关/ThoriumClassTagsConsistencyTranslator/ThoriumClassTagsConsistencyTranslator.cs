using SpiritofOverseerzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace SpiritofOverseerzhcn.ThoriumClassTagsConsistencyTranslator
{
	public class ThoriumClassTagsConsistencyTranslator
	{
		private class ThoriumClassTagsConsistency{}
		[ExtendsFromMod("ThoriumClassTagsConsistency"), JITWhenModsEnabled("ThoriumClassTagsConsistency")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumClassTagsConsistency, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("ThoriumClassTagsConsistency",out var mod))
			{
				#region ThoriumClassTagsConsistency.ClassTagsGlobalItem
				TranslatorLoad.LocalizeByTypeFullName("ThoriumClassTagsConsistency.ClassTagsGlobalItem", "ModifyTooltips", new ()
				{
					{"-Warrior Class-","-近战职业-"},
					{"-Ranger Class-","-远程职业-"},
					{"-Sorcerer Class-","-魔法师职业-"},
					{"-Summoner Class-","-召唤师职业-"},
				});
				#endregion ThoriumClassTagsConsistency.ClassTagsGlobalItem


			}
		}
	}
}
