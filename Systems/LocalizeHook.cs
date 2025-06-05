#pragma warning disable CA2255
using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Terraria.ModLoader;

namespace ThoriumModzhcn.Systems;

public static class LocalizeHook
{
    public static void LocalizationLoaderHookMethod(Action orgin)
    {
        orgin.Invoke();
        //LocalizeUtil.CutLanguage(LocalizeLoad.CurrentLanguage);
    }

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
                    var method = typeof(LocalizeUtil)
                        .GetMethod("CutLanguage", BindingFlags.Static | BindingFlags.Public);
                    iLCursor.Emit(OpCodes.Ldc_I4, (int)LocalizeLoad.CurrentLanguage);
                    iLCursor.Emit(OpCodes.Call, method);
                }
            }
        });
        UnLoad.ILHooks.Add(hook);
    }
}
