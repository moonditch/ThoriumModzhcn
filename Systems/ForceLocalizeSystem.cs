using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems
{

    //private class TranslatorLoad : ForceLocalizeSystem<TranslatorLoad, StructureHelper> { }
    public class UnLoad : ModSystem
    {
        /// <summary>
        /// Language.GetTextValue，使用Key获取值
        /// </summary>
        public static MethodInfo GetTextValue { get; } = typeof(Language).GetMethods().FirstOrDefault(met => met.Name == "GetTextValue" && met.GetParameters().Length == 1); //Language.GetTextValue;
        /// <summary>
        /// 全部类型的全类名和这个类型的引用
        /// </summary>
        public static List<Dictionary<string, Type>> List { get; } = [];
        /// <summary>
        /// 全部钩子
        /// </summary>
        public static List<ILHook> ILHooks { get; } = [];
        public override void PostSetupContent()
        {
            foreach (var item in List) {
                item.Clear();
            }
            base.PostSetupContent();
        }

        public override void Unload()
        {
            ILHooks.Clear();
            base.Unload();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSale">目标模组</typeparam>
    public class ForceLocalizeSystem<TSale, 占位符>
    {
        public static readonly Dictionary<string, Type> Types = [];

        /// <summary>
        /// 只会初始化一次，用来载入模组的全部类型
        /// </summary>
        static ForceLocalizeSystem()
        {
            if (!ModLoader.TryGetMod(typeof(TSale).Name, out Mod TarGet))
                return;
            foreach (var item in AssemblyManager.GetLoadableTypes(TarGet.Code)) {
                Types.Add(item.FullName, item);
            }
            UnLoad.List.Add(Types);
        }
        /// <summary>
        /// 对给定全名的Type的给定方法进行字符串替换
        /// </summary>
        /// <param name="TypeName">全类名</param>
        /// <param name="MethodName">方法名</param>
        /// <param name="Value">值</param>
        public static void LocalizeByTypeFullName(string TypeName, string MethodName, Dictionary<string, string> Value)
        {
            //value结构 :
            //      Key => 本地化键
            //      Value => 英文值
            if (!ModLoader.TryGetMod(typeof(TSale).Name, out Mod TarGet)) return;
            if (!Types.TryGetValue(TypeName, out Type type)) return;
            MethodInfo Method = type.GetMethod(MethodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            if (Method is null) return;

            ILHook iLHook =
            new ILHook(Method, ilc => {
                ILHookMethod(ilc, Value);
            });
            iLHook.Apply();
            UnLoad.ILHooks.Add(iLHook);
        }

        private static void ILHookMethod(ILContext ilc, Dictionary<string, string> Value)
        {
            ILCursor ILCursor = new ILCursor(ilc);
            var r = ilc.Body.Instructions;
            while (ILCursor.Next != null) {
                if (ILCursor.TryGotoNext(MoveType.After, il => il.MatchLdstr(out _))) {
                    var oldString = ILCursor.Previous.Operand.ToString();
                    foreach (var Key in Value.Keys) {
                        if (Value[Key] == oldString) {
                            //ILCursor.Index--;
                            //ILCursor.Remove();
                            //ILCursor.Emit(OpCodes.Ldstr, Key);
                            ILCursor.Prev.Operand = Key;
                            ILCursor.Emit(OpCodes.Call, UnLoad.GetTextValue);
                            if (ILCursor.Next != null)
                                ILCursor.GotoNext();
                            break;
                        }
                    }
                } else break;
            }
        }
    }
}
