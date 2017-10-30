using System.Reflection;
using Synology.Attributes;
using Synology.Utilities;
using System;
using System.Runtime.CompilerServices;
using Synology.Interfaces;

namespace Synology.Parameters
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class SynologyParameters<T> where T : IParameter
	{
		/// <summary>
		/// 
		/// </summary>
		public string Method { get; }
		/// <summary>
		/// 
		/// </summary>
		public int Version { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public T[] Additional { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <param name="methodName"></param>
		protected SynologyParameters(ISynologyRequest request, [CallerMemberName] string methodName = null)
		{
			var method = request.GetType().GetMethod(methodName);

			if (method != null)
			{
				if (method.GetCustomAttribute(typeof(RequestMethodAttribute)) is RequestMethodAttribute attr)
					Method = attr.Name;
				else
					throw new Exception("RequestMethodAttribute not found on caller method.");
			}
			else
			{
				throw new Exception("Caller Method not found.");
			}

			Version = 1;
		}
	}
}
