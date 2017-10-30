using System;
using System.Collections.Generic;
using System.Reflection;
using Synology.Attributes;

namespace Synology.Utilities
{
    public static class ApiNameHelper
    {
        public static string GetApiName<T>() => GetApiName(typeof(T));

        public static string GetApiName(Type t)
        {
            var ty = t.GetTypeInfo();
            var res = new List<string>();

            while (ty != null)
            {
                if (ty.GetCustomAttribute(typeof(RequestAttribute)) is RequestAttribute ta)
                    res.Insert(0, ta.Name);

                ty = ty.BaseType?.GetTypeInfo();
            }

            return string.Join(".", res);
        }
    }
}
