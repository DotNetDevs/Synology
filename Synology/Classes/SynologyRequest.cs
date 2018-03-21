using Synology;
using System.Threading.Tasks;
using Synology.Attributes;
using System.Collections.Generic;
using Synology.Parameters;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Synology.Api.Info;
using Synology.Interfaces;
using Synology.Utilities;

namespace Synology.Classes
{
    [Request("SYNO")]
    internal abstract class SynologyRequest : ISynologyRequest
    {
        public ISynologyApi Api { get; }
        private string _cgiPath = null;
        public string ApiName => ApiNameHelper.GetApiName(GetType());

        [Obsolete("It uses Result, migrate to Async methods")]
        public string CgiPath => CgiPathAsync().Result;

        public async Task<string> CgiPathAsync()
        {
            if (_cgiPath != null) return _cgiPath;

            //Fixed possible loop for LoadInfo
            if (ApiName == "SYNO.API.Info")
            {
                _cgiPath = "query.cgi";
            }
            else
            {
                //Request and Method returns null if the API or the Method is not found.
                var request = Api.Connection.ServiceProvider.GetService<IInfoRequest>() as ISynologyRequest;
                var data = await request?.MethodAsync<Dictionary<string, IApiInfo>>("query", new object[] { new[] { ApiName } });
                //Request and Method returns null if the API or the Method is not found.
                //If the Info API has returned a value and contains the current API Info, this update the associated cgi.
                if (data != null && data.Data.ContainsKey(ApiName))
                {
                    _cgiPath = data.Data[ApiName].Path;
                }
                else
                {
                    throw new Exception("The API cannot be found on this Synology. Check if RequestAttribute exists on the relative SynologyRequest subclass or the SYNO.API.Info result.");
                }
            }

            Api.Connection.Logger.LogDebug($"Set cgi path to path {_cgiPath}");

            return _cgiPath;
        }

        protected SynologyRequest(ISynologyApi api)
        {
            Api = api;

            Api.Connection.Logger.LogDebug($"Created request {ApiName}");
        }
    }
}
