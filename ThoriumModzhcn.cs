#pragma warning disable CA2255 // 不应在库中使用 “ModuleInitializer” 属性
using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ModLoader;
using ThoriumModzhcn.Systems;

namespace ThoriumModzhcn
{
    public class ThoriumModzhcn : Mod
    {
        [ModuleInitializer]
        public static void LoadTranslator()
        {
            ZHhjson.ZHCODETranslator.ThoriumModTranslator.LoadTranslator();
            ZHhjson.ZHCODETranslator.CalamityBardHealerTranslator.LoadTranslator();
            ZHhjson.ZHCODETranslator.SpookyBardHealerTranslator.LoadTranslator();
            ZHhjson.ZHCODETranslator.ThoriumReworkTranslator.LoadTranslator();
            ZHhjson.ZHCODETranslator.RagnarokModTranslator.LoadTranslator();
        }
    }
    public class ThoriumModzhcnPlayer : ModPlayer
    {
        public override void OnEnterWorld()
        {
            var modConfig = ModContent.GetInstance<ThoriumModConfig>();
            if (modConfig.世界启用提示 == true)
            {
                Main.NewText("乐器种类设置：ThoriumMod -> 客户端配置 -> 吟游诗人选项 -> 显示乐器类型标签选择项目打开\n切换语言：瑟银&更多附属汉化补丁 -> 语言切换 -> 滑块为台湾繁体打开无需重新加载\n如果你不想看见这两个提示或者已知这两个提示，请在瑟银汉化补丁的设置里面关闭它", Color.Orange);
            }
        }
    }
}
