#pragma warning disable CA2255
using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace ThoriumModzhcn.ZHhjson.ZHCODETranslator
{
	public class CalamityBardHealerTranslator
	{
		private class CalamityBardHealer{}
		[ExtendsFromMod("CalamityBardHealer"), JITWhenModsEnabled("CalamityBardHealer")]
		private class TranslatorLoad : ForceLocalizeSystem<CalamityBardHealer, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("CalamityBardHealer", out _))
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
