using System;
using System.Linq;
using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Extensions
{
    public static class SynologyRequestExtension
    {
        private static T MethodResult<T>(this ISynologyRequest request, string name, params object[] parameters) where T : ResultData
        {
            var type = request.GetType();
            var methods = type.GetMethods();
            var filteredMethods = methods.Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));
            var method = filteredMethods.FirstOrDefault(t => t.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().FirstOrDefault()?.Name == name);
            var response = method?.Invoke(request, parameters);
            return response as T;
        }

        internal static  ResultData Method(this ISynologyRequest request, string name, params object[] parameters) => request.MethodResult<ResultData>(name, parameters);

        internal static  ResultData<T> Method<T>(this ISynologyRequest request, string name, params object[] parameters) => request.MethodResult<ResultData<T>>(name, parameters);
    }
}
