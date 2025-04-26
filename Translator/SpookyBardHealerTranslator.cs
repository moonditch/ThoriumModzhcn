using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.Translator
{
	public class SpookyBardHealerTranslator
	{
		private class SpookyBardHealer{}
		[ExtendsFromMod("SpookyBardHealer"), JITWhenModsEnabled("SpookyBardHealer")]
		private class TranslatorLoad : ForceLocalizeSystem<SpookyBardHealer, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("SpookyBardHealer",out var mod))
			{
				#region SpookyBardHealer.Tiles.SecretPainting
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Tiles.SecretPainting", "KillMultiTile", new ()
				{
					{"SpookyBardHealer.SpookyBardHealer.Tiles.SecretPainting.KillMultiTile.51","HEY! HEY! HEY!"},
				});
				#endregion SpookyBardHealer.Tiles.SecretPainting


				#region SpookyBardHealer.Items.SecretPainting
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "UpdateInventory", new ()
				{
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.UpdateInventory.216","P L A C E   M E"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnConsumeItem", new ()
				{
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnConsumeItem.217","A finɘ ɒɹʇwork"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnConsumeItem.218","A mɒsʇǝɹpiɘce"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnConsumeItem.219","Bɘɒutiful!"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnConsumeItem.220","1 pǝǝu ʏ0u"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnSpawn", new ()
				{
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnSpawn.222","Why mnsʇ y0u foɹsɒkǝ mɘ"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnSpawn.223","D0n't lɘɒvǝ me!!!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnStack", new ()
				{
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnStack.224","Wǝ. Aɹe. Ouɘ!"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnStack.225","Яǝunion!!"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnStack.226","t0gɘtheɹ, sʇrongǝr!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnPickup", new ()
				{
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnPickup.228","Яǝunitɘd 0ncɘ more..."},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnPickup.229","Ͷevɘɿ leɒvǝ mǝ agɒin!"},
					{"SpookyBardHealer.SpookyBardHealer.Items.SecretPainting.OnPickup.230","GoOd, g0od!!"},
				});
				#endregion SpookyBardHealer.Items.SecretPainting


			}
		}
	}
}
