using SpiritofOverseerzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace SpiritofOverseerzhcn.SpiritofOverseerTranslator
{
	public class SpiritofOverseerTranslator
	{
		private class SpiritofOverseer{}
		[ExtendsFromMod("SpiritofOverseer"), JITWhenModsEnabled("SpiritofOverseer")]
		private class TranslatorLoad : ForceLocalizeSystem<SpiritofOverseer, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("SpiritofOverseer",out var mod))
			{
				#region SpiritofOverseer.SpiritPlayer
				TranslatorLoad.LocalizeByTypeFullName("SpiritofOverseer.SpiritPlayer", "OnEnterWorld", new ()
				{
					{"PHOTOSENSITIVITY WARNING: \"Hardmode Spirit Bosses Rework\" mod adds a lot of flashy effects! Especially in boss fights!\nIf you are photosensitive, go to Settings -> Mod Configuration -> Hardmode Spirit Bosses Rework -> Visual Settings and set all the sliders to 0!\nYou can turn off this warning in the config as well if you do not want to keep seeing it!","光 敏 警 告: \"Hardmode Spirit Bosses Rework\" 模组增加了很多华丽的效果！尤其是在boss战中！\n如果你感觉到不适，请转到设置 -> 模组配置 -> Hardmode Spirit Bosses Rework -> 视觉设置，并将所有设置调整为0！\n如果你不想看到这个警告，也可以在配置中关闭它！---来自困难后魂灵BOSS重置的提醒！"},
				});
				#endregion SpiritofOverseer.SpiritPlayer


			}
		}
	}
}
