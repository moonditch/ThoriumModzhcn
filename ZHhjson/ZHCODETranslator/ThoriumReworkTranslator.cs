#pragma warning disable CA2255
using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace ThoriumModzhcn.ZHhjson.ZHCODETranslator
{
	public class ThoriumReworkTranslator
	{
		private class ThoriumRework{}
		[ExtendsFromMod("ThoriumRework"), JITWhenModsEnabled("ThoriumRework")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumRework, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("ThoriumRework",out _))
			{
				#region ThoriumRework.Items.BeholderHeart
				TranslatorLoad.LocalizeByTypeFullName("ThoriumRework.Items.BeholderHeart", "SetDefaults", new ()
				{
					{"ThoriumRework.ThoriumRework.Items.BeholderHeart.SetDefaults.2644","90 basic damage"},
				});
				#endregion ThoriumRework.Items.BeholderHeart


			}
		}
	}
}
