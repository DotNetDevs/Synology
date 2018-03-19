using System.Collections.Generic;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api.Info
{
	/// <summary>
	/// 
	/// </summary>
	public interface IInfoRequest : ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="apis"></param>
		/// <returns></returns>
		ResultData<Dictionary<string, IApiInfo>> Query(params string[] apis);
	}
}
