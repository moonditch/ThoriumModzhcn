using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems;

public class UnLoad : ModSystem
{
    /// <summary>
    /// 全部类型的全类名和这个类型的引用
    /// </summary>
    public static List<Dictionary<string, Type>> List { get; } = [];
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

    public static void LocalizeByTypeFullName(string typeName, string methodName, Dictionary<string, string> values)
    {
        //value结构 :
        //      Key => 本地化键

        //      Value => 英文值
        //if (!ModLoader.TryGetMod(typeof(TSale).Name, out Mod TarGet)) return;
        if (!LoadModAssembly.LoadModContext.TryGetValue(typeof(TSale).Name, out _))
            return;

        if (!Types.TryGetValue(typeName, out Type type)) return;

        UpHook(type, methodName, values);
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
                        ILCursor.Prev.Operand = Key;
                        ILCursor.Emit(OpCodes.Call, LocalizeExtend.GetTextValue);
                        if (ILCursor.Next != null)
                            ILCursor.GotoNext();
                        break;
                    }
                }
            } else break;
        }
    }
}


public static class LocalizeHook
{
    [ModuleInitializer]
    public static void UpLocalizationLoaderHook()
    {
        var BFSN = BindingFlags.Static | BindingFlags.NonPublic;
        var tarMethod = typeof(LocalizationLoader).GetMethod("Update", BFSN);
        if (tarMethod == null)
            return;
        //MonoModHooks.Add(tarMethod, LocalizationLoaderHookMethod);
        ILHook hook =
        new ILHook(tarMethod, il => {
            var iLCursor = new ILCursor(il);
            while (iLCursor.Next != null) {
                iLCursor.TryGotoNext();
                var currILOper = iLCursor.Previous?.Operand;
                if (currILOper == null)
                    continue;

                //"IL_006a: call System.Void Terraria.Utils::LogAndChatAndConsoleInfoMessage(System.String)"
                //"IL_00e9: callvirt System.Void Terraria.Localization.LanguageManager::ReloadLanguage(System.Boolean)"
                if (currILOper.ToString().Contains("System.Void Terraria.Localization.LanguageManager::ReloadLanguage")) {
                    //iLCursor.GotoNext();
                    var method = typeof(LocalizeNew)
                        .GetMethod("LangSwitcher", BindingFlags.Static | BindingFlags.Public);
                    //iLCursor.Emit(OpCodes.Ldc_I4, (int)LocalizeLoad.CurrentLanguage);
                    iLCursor.Emit(OpCodes.Call, method);
                }
            }
        });
        UnLoad.ILHooks.Add(hook);
    }

    [ModuleInitializer]
    internal static void HookLoadFilesForCulture()
    {
        var method = typeof(LanguageManager).GetMethod("LoadFilesForCulture", BindingFlags.Instance | BindingFlags.NonPublic);
        MonoModHooks.Add(method, LoadFilesForCultureHookMethod);
    }

    private delegate void LoadFilesForCultureDel(object obj, GameCulture gcul);
    private static void LoadFilesForCultureHookMethod(LoadFilesForCultureDel orig, object obj, GameCulture gcul)
    {
        orig.Invoke(obj, gcul); //todo
        LocalizeNew.LangSwitcher();
    }
}

