#nullable enable
/**
 * 作者 Tigerzzz
 * https://github.com/TigerChenzzz
 */
using log4net;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems;

/*internal class ForceLocalizeSystem : ForceLocalizeSystem<Stellamod.Stellamod, ForceLocalizeSystem>
{
    protected override string ReplaceString(string old, string @new) => @new == "填入汉化文本" ? old : @new;
#if DEBUG
    protected override bool ThrowException => true;
#endif
}*/

/// <summary>
/// 如果是弱依赖的话要加上 <see cref="ExtendsFromModAttribute"/>
/// </summary>
/// <typeparam name="TMod">要汉化的模组的类</typeparam>
/// <typeparam name="TSelf">继承了此类的类自己</typeparam>
public abstract class ForceLocalizeSystemTiger<TMod, TSelf> where TSelf : ForceLocalizeSystemTiger<TMod, TSelf> /* where T : Mod */
{
    #region Instance
    protected static TSelf DefaultInitializeFunction()
    {
        return (TSelf)(Activator.CreateInstance(typeof(TSelf)) ?? throw new NullReferenceException("Activator.CreateInstance return null for type " + typeof(TSelf)));
    }
    protected static Func<TSelf> InitializeFunction { get; set; } = DefaultInitializeFunction;
    private static TSelf? _instance;
    protected static TSelf Instance { get => _instance ??= InitializeFunction(); }
    #endregion
    #region Localize
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// <br/>如果不想用反射, 可以使用<see cref="LocalizeByTypeFullName"/>
    /// <br/>或 <see cref="LocalizeByTypeName"/>
    /// <br/>或 <see cref="LocalizeByType"/>
    /// <br/>注意如果此方法有多个重载 (即多个重名的方法), 则上述三个无法使用 (只能用这个)
    /// </summary>
    /// <param name="methodInfo">此方法, 由反射得到</param>
    /// <param name="localizations">需要替换的字符串, 键为替换前, 值为替换后</param>
    public static void Localize(MethodInfo? methodInfo, Dictionary<string, string> localizations)
    {
        if (methodInfo == null)
        {
            LogError("Method Null!\n" + new StackTrace());
            return;
        }
        if (localizations.Count == 0)
        {
            return;
        }
        MonoModHooks.Modify(methodInfo, il =>
        {
            ILCursor cursor = new(il);
            string? str = null;
            while (cursor.TryGotoNext(i => i.MatchLdstr(out str)))
            {
                if (str != null && cursor.Next != null && localizations.TryGetValue(str, out var value))
                {
                    cursor.Next.Operand = Instance.ReplaceString(str, value);
                }
            }
        });
    }
    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// </summary>
    /// <param name="type">包含此方法的类型</param>
    /// <param name="methodName">此方法名</param>
    /// <inheritdoc cref="Localize"/>
    public static void LocalizeByType(Type type, string methodName, Dictionary<string, string> localizations)
    {
        MethodInfo? methodInfo;
        try
        {
            methodInfo = type.GetMethod(methodName, BFALL);
        }
        catch (Exception e)
        {
            LogError("Localize error", e);
            return;
        }
        if (methodInfo == null)
        {
            LogErrorFormat("Can't find method {0} in type {1}", methodInfo, type);
            return;
        }
        Localize(methodInfo, localizations);
    }
    /// <param name="typeName">包含此方法的类型的名字, 注意此类型必须在需汉化的模组中</param>
    /// <param name="methodName">此方法名</param>
    /// <inheritdoc cref="LocalizeByType"/>
    public static void LocalizeByTypeName(string typeName, string methodName, Dictionary<string, string> localizations)
    {
        if (!TypeHelper.TypeByName.TryGetValue(typeName, out Type? type))
        {
            LogErrorFormat("Can't find type by name: {0}", typeName);
            return;
        }
        if (TypeHelper.DuplicatedNames.Contains(typeName))
        {
            LogWarnFormat("Type duplicated: {0}", typeName);
        }
        LocalizeByType(type, methodName, localizations);
    }
    /// <param name="typeFullName">
    /// <br/>包含此方法的类型的全名, 注意此类型必须在需汉化的模组中
    /// <br/>包含命名空间, 由 '.' 分隔
    /// <br/>例: LunarVeilChinesePack.Systems.ForceLocalizeSystem
    /// <br/>如果是内嵌类型, 则用 '+' 连接
    /// <br/>例: LunarVeilChinesePack.Systems.ForceLocalizeSystem+TypeHelper
    /// </param>
    /// <inheritdoc cref="LocalizeByTypeName"/>
    public static void LocalizeByTypeFullName(string typeFullName, string methodName, Dictionary<string, string> localizations)
    {
        if (!TypeHelper.TypeByFullName.TryGetValue(typeFullName, out Type? type))
        {
            LogErrorFormat("Can't find type by full name: {0}", typeFullName);
            return;
        }
        LocalizeByType(type, methodName, localizations);
    }

    /// <summary>
    /// <br/>替换一个方法中的字符串
    /// <br/>只能在加载阶段使用
    /// <br/>如果不想用反射, 可以使用<see cref="LocalizeInOrderByTypeFullName"/>
    /// <br/>或 <see cref="LocalizeInOrderByTypeName"/>
    /// <br/>或 <see cref="LocalizeInOrderByType"/>
    /// <br/>注意如果此方法有多个重载 (即多个重名的方法), 则上述三个无法使用 (只能用这个)
    /// </summary>
    /// <param name="localizationsInOrder">
    /// <br/>需要替换的字符串, 需按顺序装有 (替换前, 替换后) 的值
    /// <br/>即使不需要替换也要写上一项 (替换前和替换后相同的值)
    /// </param>
    /// <inheritdoc cref="Localize"/>
    public static void LocalizeInOrder(MethodInfo? methodInfo, List<(string Key, string Value)> localizationsInOrder)
    {
        if (methodInfo == null)
        {
            LogError("Method Null!\n" + new StackTrace());
            return;
        }
        if (localizationsInOrder.Count == 0)
        {
            return;
        }
        MonoModHooks.Modify(methodInfo, il =>
        {
            ILCursor cursor = new(il);
            string? str = null;
            int i = 0;
            while (cursor.TryGotoNext(i => i.MatchLdstr(out str)))
            {
                if (str == null || cursor.Next == null || localizationsInOrder[i].Key != str)
                {
                    continue;
                }
                cursor.Next.Operand = localizationsInOrder[i].Value;
                i += 1;
                if (localizationsInOrder.Count <= i)
                {
                    return;
                }
            }
        });
    }
    /// <inheritdoc cref="LocalizeByType"/>
    /// <inheritdoc cref="LocalizeInOrder"/>
    public static void LocalizeInOrderByType(Type type, string methodName, List<(string Key, string Value)> localizationsInOrder)
    {
        MethodInfo? methodInfo;
        try
        {
            methodInfo = type.GetMethod(methodName, BFALL);
        }
        catch (Exception e)
        {
            LogError("Localize error", e);
            return;
        }
        if (methodInfo == null)
        {
            LogErrorFormat("Can't find method {0} in type {1}", methodInfo, type);
            return;
        }
        LocalizeInOrder(methodInfo, localizationsInOrder);
    }
    /// <inheritdoc cref="LocalizeInOrderByType"/>
    /// <inheritdoc cref="LocalizeByTypeName"/>
    public static void LocalizeInOrderByTypeName(string typeName, string methodName, List<(string Key, string Value)> localizationsInOrder)
    {
        if (!TypeHelper.TypeByName.TryGetValue(typeName, out Type? type))
        {
            LogErrorFormat("Can't find type by name: {0}", typeName);
            return;
        }
        if (TypeHelper.DuplicatedNames.Contains(typeName))
        {
            LogWarnFormat("Type duplicated: {0}", typeName);
        }
        LocalizeInOrderByType(type, methodName, localizationsInOrder);
    }
    /// <inheritdoc cref="LocalizeInOrderByType"/>
    /// <inheritdoc cref="LocalizeByTypeFullName"/>
    public static void LocalizeInOrderByTypeFullName(string typeFullName, string methodName, List<(string Key, string Value)> localizationsInOrder)
    {
        if (!TypeHelper.TypeByFullName.TryGetValue(typeFullName, out Type? type))
        {
            LogErrorFormat("Can't find type by full name: {0}", typeFullName);
            return;
        }
        LocalizeInOrderByType(type, methodName, localizationsInOrder);
    }

    /// <summary>
    /// <br/>替换所有子类中此方法的重写中的字符串
    /// <br/>只能在加载阶段使用
    /// <br/>如果不想用反射, 可以使用<see cref="LocalizeDerivedByType"/>
    /// <br/>注意如果此方法有多个重载 (即多个重名的方法), 则上面那个无法使用 (只能用这个)
    /// </summary>
    /// <param name="includeSelf">是否同时替换此方法下的字符串</param>
    /// <inheritdoc cref="Localize"/>
    public static void LocalizeDerived(MethodInfo? methodInfo, Dictionary<string, string> localizations, bool includeSelf = false)
    {
        if (methodInfo == null)
        {
            LogError("Method Null!\n" + new StackTrace());
            return;
        }
        if (includeSelf)
        {
            Localize(methodInfo, localizations);
        }
        if (methodInfo.ReflectedType == null)
        {
            LogError("Method Don't have a reflectedType!\n" + new StackTrace());
            return;
        }
        if (!methodInfo.IsVirtual)
        {
            return;
        }
        string methodName = methodInfo.Name;
        Type[] types = methodInfo.GetParameters().Select(p => p.ParameterType).ToArray();
        foreach (var type in TypeHelper.TypeByFullName.Values)
        {
            if (!type.IsSubclassOf(methodInfo.ReflectedType))
            {
                continue;
            }
            var method = type.GetMethod(methodName, BFALL, types);
            if (method == null || method.DeclaringType != type)
            {
                continue;
            }
            Localize(method, localizations);
        }
    }
    /// <summary>
    /// <br/>替换所有子类中此方法的重写中的字符串
    /// <br/>只能在加载阶段使用
    /// </summary>
    /// <inheritdoc cref="LocalizeDerived"/>
    /// <inheritdoc cref="LocalizeByType"/>
    public static void LocalizeDerivedByType(Type type, string methodName, Dictionary<string, string> localizations, bool includeSelf = false)
    {
        MethodInfo? methodInfo;
        try
        {
            methodInfo = type.GetMethod(methodName, BFALL);
        }
        catch (Exception e)
        {
            LogError("Localize error", e);
            return;
        }
        if (methodInfo == null)
        {
            LogErrorFormat("Can't find method {0} in type {1}", methodInfo, type);
            return;
        }
        LocalizeDerived(methodInfo, localizations, includeSelf);
    }
    /// <inheritdoc cref="LocalizeDerivedByType"/>
    /// <inheritdoc cref="LocalizeByTypeName"/>
    public static void LocalizeDerivedByTypeName(string typeName, string methodName, Dictionary<string, string> localizations, bool includeSelf = false)
    {
        if (!TypeHelper.TypeByName.TryGetValue(typeName, out Type? type))
        {
            LogErrorFormat("Can't find type by name: {0}", typeName);
            return;
        }
        if (TypeHelper.DuplicatedNames.Contains(typeName))
        {
            LogWarnFormat("Type duplicated: {0}", typeName);

        }
        LocalizeDerivedByType(type, methodName, localizations, includeSelf);
    }
    /// <inheritdoc cref="LocalizeDerivedByTypeName"/>
    /// <inheritdoc cref="LocalizeByTypeFullName"/>
    public static void LocalizeDerivedByTypeFullName(string typeFullName, string methodName, Dictionary<string, string> localizations, bool includeSelf = false)
    {
        if (!TypeHelper.TypeByFullName.TryGetValue(typeFullName, out Type? type))
        {
            LogErrorFormat("Can't find type by full name: {0}", typeFullName);
            return;
        }
        LocalizeDerivedByType(type, methodName, localizations, includeSelf);
    }
    #endregion
    protected virtual string ReplaceString(string old, string @new) => @new;
    #region Log
    protected virtual bool NeedLog => true;
    protected virtual bool ThrowException => false;
    protected virtual ILog Logger { get; } = Logging.PublicLogger;
    private const string LogConditionalString = "DEBUG";
    [Conditional(LogConditionalString)]
    protected static void LogWarn(object message)
    {
        if (Instance.NeedLog)
        {
            Instance.Logger.Warn(message);
        }
    }
    [Conditional(LogConditionalString)]
    protected static void LogWarnFormat(string message, object? arg0)
    {
        if (Instance.NeedLog)
        {
            Instance.Logger.WarnFormat(message, arg0);
        }
    }
    [Conditional(LogConditionalString)]
    protected static void LogError(object message)
    {
        if (Instance.NeedLog)
        {
            Instance.Logger.Error(message);
        }
        if (Instance.ThrowException)
        {
            throw new Exception("Localize error!");
        }
    }
    [Conditional(LogConditionalString)]
    protected static void LogError(object message, Exception exception)
    {
        if (Instance.NeedLog)
        {
            Instance.Logger.Error(message, exception);
        }
        if (Instance.ThrowException)
        {
            throw new Exception("Localize error!");
        }
    }
    [Conditional(LogConditionalString)]
    protected static void LogErrorFormat(string message, object? arg0)
    {
        if (Instance.NeedLog)
        {
            Instance.Logger.ErrorFormat(message, arg0);
        }
        if (Instance.ThrowException)
        {
            throw new Exception("Localize error!");
        }
    }
    [Conditional(LogConditionalString)]
    protected static void LogErrorFormat(string message, object? arg0, object? arg1)
    {
        if (Instance.NeedLog)
        {
            Instance.Logger.ErrorFormat(message, arg0, arg1);
        }
        if (Instance.ThrowException)
        {
            throw new Exception("Localize error!");
        }
    }
    #endregion

    static ForceLocalizeSystemTiger()
    {
        Hook? postSetupRecipesHook = null;
        postSetupRecipesHook = new(typeof(SystemLoader).GetMethod("PostSetupRecipes", BFALL) ?? throw new NullReferenceException("Can't find SystemLoader.PostSetupRecipes"), (Action<Mod> orig, Mod mod) =>
        {
            orig(mod);
            TypeHelper.Clear();
            if (postSetupRecipesHook != null)
            {
                postSetupRecipesHook.Dispose(); // 包含 Undo
                postSetupRecipesHook = null;
            }
        });
    }

    private const BindingFlags BFALL = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    public static class TypeHelper
    {
        private static Assembly? modAssembly;
        public static Assembly ModAssembly
        {
            get
            {
                if (modAssembly == null)
                {
                    Initialize();
                }
                return modAssembly;
            }
        }
        private static Dictionary<string, Type>? typesByName;
        public static Dictionary<string, Type> TypeByName
        {
            get
            {
                if (typesByName == null)
                {
                    Initialize();
                }
                return typesByName;
            }
        }
        private static HashSet<string>? duplicatedNames;
        public static HashSet<string> DuplicatedNames
        {
            get
            {
                if (duplicatedNames == null)
                {
                    Initialize();
                }
                return duplicatedNames;
            }
        }
        private static Dictionary<string, Type>? typeByFullName;
        public static Dictionary<string, Type> TypeByFullName
        {
            get
            {
                if (typeByFullName == null)
                {
                    Initialize();
                }
                return typeByFullName;
            }
        }
        private static bool initialized;
        [MemberNotNull(nameof(modAssembly), nameof(typesByName), nameof(typeByFullName), nameof(duplicatedNames))]
        private static void Initialize()
        {
            if (cleared)
            {
                throw new Exception("在完成后初始化!");
            }
            if (initialized)
            {
                throw new Exception("重复初始化!");
            }
            initialized = true;
            //标记点
            String ModName = typeof(TMod).Name;
            modAssembly = ModLoader.GetMod(ModName).GetType().Assembly; /*typeof(TMod).Assembly;*/ // mod.Code??
            typesByName = [];
            typeByFullName = [];
            duplicatedNames = [];
            foreach (var type in AssemblyManager.GetLoadableTypes(modAssembly))
            {
                if (!typesByName.TryAdd(type.Name, type))
                {
                    duplicatedNames.Add(type.Name);
                }
                if (type.FullName != null)
                {
                    typeByFullName.TryAdd(type.FullName, type);
                }
            }
        }
        private static bool cleared;
        public static void Clear()
        {
            cleared = true;
            initialized = false;
            modAssembly = null;
            typesByName = null;
            typeByFullName = null;
            duplicatedNames = null;
        }
    }
}

internal static class ListAddExtensions
{
    public static void Add<T1, T2>(this List<(T1, T2)> self, T1 t1, T2 t2) => self.Add((t1, t2));
}