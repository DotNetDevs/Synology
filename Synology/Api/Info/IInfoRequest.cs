using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<Dictionary<string, IApiInfo>> Query(params string[] apis);

        /// <summary>
        /// Queries the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="apis">Apis.</param>
        Task<ResultData<Dictionary<string, IApiInfo>>> QueryAsync(params string[] apis);
	}
}
