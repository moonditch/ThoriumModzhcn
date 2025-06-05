using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems
{

    //private class TranslatorLoad : ForceLocalizeSystem<TranslatorLoad, StructureHelper> { }
    public class UnLoad : ModSystem
    {
        private static MethodInfo getTextValue;
        /// <summary>
        /// Language.GetTextValue，使用Key获取值
        /// </summary>
        public static MethodInfo GetTextValue 
        {
            get
            {
                return getTextValue ??= typeof(Terraria.Localization.Language).GetMethods().FirstOrDefault(met => met.Name == "GetTextValue" && met.GetParameters().Length == 1);
            } 
            
        } //Language.GetTextValue;
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


    public static class LoadModAssembly
    {
        private static BindingFlags BSN = BindingFlags.Static | BindingFlags.NonPublic;
        private static Dictionary<string, object> loadModContext;
        public static Dictionary<string, object> LoadModContext
        {
            get
            {
                //获取 AssemblyManager.loadedModContexts的值
                if (loadModContext is null) {
                    var dic = (IDictionary)typeof(AssemblyManager)
                            .GetField("loadedModContexts", BSN)
                            .GetValue(null);
                    loadModContext = [];


                    foreach (var item in dic.Keys) {
                        if (item is string key) {
                            loadModContext.Add(key, dic[key]);
                        }
                    }
                }
                return loadModContext;
            }
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
            //if (!ModLoader.TryGetMod(typeof(TSale).Name, out Mod TarGet))
            if (!LoadModAssembly.LoadModContext.TryGetValue(typeof(TSale).Name, out var modAssemblyContext))
                return;
            Assembly modAssembly = (Assembly)modAssemblyContext.GetType().GetField("assembly").GetValue(modAssemblyContext);

            //https://github.com/tModLoader/tModLoader/blob/18852534cfecf40a92c01786610a648de6dc23a2/patches/tModLoader/Terraria/ModLoader/Core/AssemblyManager.cs#L25
            foreach (var item in AssemblyManager.GetLoadableTypes(modAssembly/*TarGet.Code*/)) {
                Types.Add(item.FullName, item);
            }
            UnLoad.List.Add(Types);
        }

        /// <summary>
        /// 对给定全名的Type的给定方法进行字符串替换
        /// </summary>
        /// <param name="typeName">全类名</param>
        /// <param name="methodName">方法名</param>
        /// <param name="values">值</param>
        public static void LocalizeByTypeFullName(string typeName, string methodName, Dictionary<string, string> values)
        {
            //value结构 :
            //      Key => 本地化键

            //      Value => 英文值
            //if (!ModLoader.TryGetMod(typeof(TSale).Name, out Mod TarGet)) return;
            if (!LoadModAssembly.LoadModContext.TryGetValue(typeof(TSale).Name, out _))
                return;

            if (!Types.TryGetValue(typeName, out Type type)) return;

            /*//是泛型type 并包含未闭合泛型参数 含有未闭合返回true
            if(type.IsGenericType && type.ContainsGenericParameters) {
                //var genericTypes = type.GetGenericArguments(); //泛型参数列表
                //foreach (var genericType in genericTypes) {
                //    foreach (var item in Types.Values) {
                //        
                //    }
                //}
                //
                //
                //
                //foreach (var currType in Types.Values) { //遍历此模组类型
                //    List<Type> genericMakeTypes = [];
                //    bool currIsTarType = true; //此类型是否合规
                //    foreach (var genericType in genericTypes) {
                //        var genericTypeBind = genericType.GetGenericParameterConstraints();
                //        currType.IsGenericTypeBind(genericTypeBind, ref currIsTarType);
                //        if (currIsTarType == false) continue;
                //    }
                //}


                //派生自此泛型类的全部类
                List<Type> genericFType = Types.Values
                    .Where(atype => {
                        return 
                            atype.IsSubclassOf(type) &&
                            !atype.ContainsGenericParameters;
                    })
                    .ToList();

                foreach (var item in genericFType) {
                    UpHook(item, methodName, values);
                }*/
            //} else {
                UpHook(type, methodName, values);
            //}
        }

        private static void UpHook(Type tarType, string methodName, Dictionary<string, string> values)
        {
            List<MethodInfo> methods = tarType
                .GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .Where(m => m.Name.Contains(methodName))
                .ToList();
            if (methods.Count == 0) return;
            foreach (var methodInfo in methods) {
                ILHook iLHook =
                new ILHook(methodInfo, ilc => {
                    ILHookMethod(ilc, values);
                });
                iLHook.Apply();
                UnLoad.ILHooks.Add(iLHook);
            }
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
