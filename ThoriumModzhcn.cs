using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

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
            ZHhjson.ZHCODETranslator.RagnarokModTranslator.LoadTranslator();
        }
    }
    public class ThoriumModzhcnPlayer : ModPlayer
    {
        public override void OnEnterWorld()
        {
            Main.NewText("乐器种类设置：ThoriumMod -> 客户端配置 -> 吟游诗人选项 -> 显示乐器类型标签选择项目打开\n切换语言：瑟银&更多附属汉化补丁 -> 语言切换 -> 滑块为台湾繁体打开无需重新加载", Color.Orange);
        }
    }
}
