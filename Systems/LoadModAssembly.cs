using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria.Localization;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems;

public static class LoadModAssembly
{
    public static BindingFlags BFSN = BindingFlags.Static | BindingFlags.NonPublic;
    public static BindingFlags BFIN = BindingFlags.Instance | BindingFlags.NonPublic;

    private static Dictionary<string, object> loadModContext;
    public static Dictionary<string, object> LoadModContext
    {
        get
        {
            //获取 AssemblyManager.loadedModContexts的值
            if (loadModContext is null) {
                var dic = (IDictionary)typeof(AssemblyManager)
                        .GetField("loadedModContexts", BFSN)
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
