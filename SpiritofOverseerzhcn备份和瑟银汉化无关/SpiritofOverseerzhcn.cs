using System.Linq;
using System.Reflection;
using System.Threading;
using Terraria;
using Terraria.ModLoader;
namespace SpiritofOverseerzhcn
{
	public class SpiritofOverseerzhcn : Mod
	{
		public override void Load()
		{
			ThoriumClassTagsConsistencyTranslator.ThoriumClassTagsConsistencyTranslator.LoadTranslator();
			SpiritofOverseerTranslator.SpiritofOverseerTranslator.LoadTranslator();
			base.Load();
		}
	}
}
