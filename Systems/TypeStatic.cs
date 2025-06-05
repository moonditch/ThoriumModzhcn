using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ThoriumModzhcn.Systems;

public static class TypeStatic
{
    /// <summary>
    /// 判断给定类型是否符合泛型约束
    /// </summary>
    /// <param name="genericTypeBind"> 泛型约束列表 </param>
    /// <param name="currType"> 给定类型 </param>
    /// <param name="currIsTarType"> 符合 true 不符合 false </param>
    public static void IsGenericTypeBind(this Type currType, IEnumerable<Type> genericTypeBind, ref bool currIsTarType)
    {
        bool isValueType = genericTypeBind.Contains(typeof(ValueType)); //值类型约束
        currIsTarType = currIsTarType && (currType.IsValueType && isValueType);
        if (currIsTarType == false)
            return;

        foreach (var gbindType in genericTypeBind) {
            if (gbindType.IsInterface)//约束是接口 判断此类是否实现此接口
                currIsTarType = currIsTarType && currType.GetInterfaces().Contains(gbindType);
            else  //是否继承此类
                currIsTarType = currIsTarType && currType.IsSubclassOf(gbindType);
            if (currIsTarType == false)
                break;
        }
    }

    public static bool IsGenericTypeBind(this Type currType, IEnumerable<Type> genericTypeBind)
    {
        bool typeIsTar = true;
        currType.IsGenericTypeBind(genericTypeBind, ref typeIsTar);
        return typeIsTar;
    }

    /// <summary>
    /// 如果此类型是未闭合泛型 返回true
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    private static bool IsGenericOpenType(this Type type)
    {
        return !type.IsGenericType || type.ContainsGenericParameters;
    }
}
