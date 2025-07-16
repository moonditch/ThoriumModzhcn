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
				#region ThoriumRework.ThoriumPlayer
				TranslatorLoad.LocalizeByTypeFullName("ThoriumRework.ThoriumPlayer", "OnEnterWorld", new ()
				{
					{"ThoriumRework.ThoriumRework.ThoriumPlayer.OnEnterWorld.1269","PHOTOSENSITIVITY WARNING: \"Thorium Bosses Rework\" mod adds a lot of flashy effects! Especially in boss fights!\nIf you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!\nYou can turn off this warning in the config as well if you do not want to keep seeing it!"},
				});
				#endregion ThoriumRework.ThoriumPlayer


			}
		}
	}
}
