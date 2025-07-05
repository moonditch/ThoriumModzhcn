using System;
using System.Reflection;
using Terraria.Localization;

namespace ThoriumModzhcn.Systems;

public static class LanguageManagerExtend
{
    private static BindingFlags BFIN = BindingFlags.Instance | BindingFlags.NonPublic;
    private readonly static Type LanguageManagerType = typeof(LanguageManager);
    private readonly static MethodInfo LanguageManagerProcessCopyCommandsInTexts = LanguageManagerType.GetMethod("ProcessCopyCommandsInTexts", BFIN);
    private readonly static MethodInfo LanguageManagerRecalculateBoundTextValues = LanguageManagerType.GetMethod("RecalculateBoundTextValues", BFIN);
    private readonly static object lockobj = new object();

    public static void RecalculateBoundTextValues(this LanguageManager lm)
    {
        lock (lockobj) {
            LocalizeNew.LangSwitcher();
            LanguageManagerProcessCopyCommandsInTexts.Invoke(lm, []);
            LanguageManagerRecalculateBoundTextValues.Invoke(lm, []);
        }
    }

}
