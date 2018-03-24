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
        /// Queries the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="apis">Apis.</param>
        Task<ResultData<Dictionary<string, IApiInfo>>> QueryAsync(params string[] apis);
	}
}
