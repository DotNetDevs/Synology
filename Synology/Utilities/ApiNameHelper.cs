using System;
using System.Collections.Generic;
using System.Reflection;
using Synology.Attributes;

namespace Synology.Utilities
{
	/// <summary>
	/// 
	/// </summary>
	internal static class ApiNameHelper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static string GetApiName<T>() => GetApiName(typeof(T));

		/// <summary>
		/// 
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
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
