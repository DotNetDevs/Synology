using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Parameters;
using Microsoft.Extensions.Logging;
using Synology.Api.Info.Results;
using Synology.Interfaces;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Synology.Api.Info
{
    /// <inheritdoc cref="MainApiRequest" />
    /// <summary>
    /// </summary>
    [Request("Info")]
    internal class InfoRequest : MainApiRequest, IInfoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="api"></param>
        public InfoRequest(IApi api) : base(api)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="apis"></param>
        /// <returns></returns>
        [RequestMethod("query")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData<Dictionary<string, IApiInfo>> Query(params string[] apis)
        {
            Api.Connection.Logger.LogDebug($"Requesting Info for {(apis.Length > 0 ? string.Join(";", apis) : "all")} APIs");

            var additionalParams = new[]
            {
                apis.Length > 0 ? new QueryStringParameter("query", apis) : new QueryStringParameter("query", "all")
            };

            var res = GetData<Dictionary<string, ApiInfo>>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });

            return new ResultData<Dictionary<string, IApiInfo>>
            {
                Error = res.Error,
                Success = res.Success,
                Data = res.Data.ToDictionary(t => t.Key, t => (IApiInfo)t.Value)
            };
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="apis"></param>
        /// <returns></returns>
        [RequestMethod("query")]
        public async Task<ResultData<Dictionary<string, IApiInfo>>> QueryAsync(params string[] apis)
        {
            Api.Connection.Logger.LogDebug($"Requesting Info for {(apis.Length > 0 ? string.Join(";", apis) : "all")} APIs");

            var additionalParams = new[]
            {
                apis.Length > 0 ? new QueryStringParameter("query", apis) : new QueryStringParameter("query", "all")
            };

            var res = await GetDataAsync<Dictionary<string, ApiInfo>>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });

            return new ResultData<Dictionary<string, IApiInfo>>
            {
                Error = res.Error,
                Success = res.Success,
                Data = res.Data.ToDictionary(t => t.Key, t => (IApiInfo)t.Value)
            };
        }
    }
}