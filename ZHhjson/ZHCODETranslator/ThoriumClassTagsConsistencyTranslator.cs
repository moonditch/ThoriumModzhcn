using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ZHhjson.ZHCODETranslator
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
					{"ThoriumClassTagsConsistency.ThoriumClassTagsConsistency.ClassTagsGlobalItem.ModifyTooltips.70","-Warrior Class-"},
					{"ThoriumClassTagsConsistency.ThoriumClassTagsConsistency.ClassTagsGlobalItem.ModifyTooltips.71","-Ranger Class-"},
					{"ThoriumClassTagsConsistency.ThoriumClassTagsConsistency.ClassTagsGlobalItem.ModifyTooltips.72","-Sorcerer Class-"},
					{"ThoriumClassTagsConsistency.ThoriumClassTagsConsistency.ClassTagsGlobalItem.ModifyTooltips.73","-Summoner Class-"},
				});
				#endregion ThoriumClassTagsConsistency.ClassTagsGlobalItem


			}
		}
	}
}
