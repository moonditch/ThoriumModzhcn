using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.Translator
{
	public class CalamityBardHealerTranslator
	{
		private class CalamityBardHealer{}
		[ExtendsFromMod("CalamityBardHealer"), JITWhenModsEnabled("CalamityBardHealer")]
		private class TranslatorLoad : ForceLocalizeSystem<CalamityBardHealer, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("CalamityBardHealer",out var mod))
			{
				#region CalamityBardHealer.Items.SymphonicFabrications
				TranslatorLoad.LocalizeByTypeFullName("CalamityBardHealer.Items.SymphonicFabrications", "BardModifyTooltips", new ()
				{
					{"CalamityBardHealer.CalamityBardHealer.Items.SymphonicFabrications.BardModifyTooltips.1228","Variety IV"},
					{"CalamityBardHealer.CalamityBardHealer.Items.SymphonicFabrications.BardModifyTooltips.1229","Playing empowers players with bonus:"},
				});
				#endregion CalamityBardHealer.Items.SymphonicFabrications


			}
		}
	}
}
