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
        public string CgiPath { get; private set; }
        public string ApiName => ApiNameHelper.GetApiName(GetType());

        protected SynologyRequest(ISynologyApi api)
        {
            Api = api;

            //Fixed possible loop for LoadInfo
            if (ApiName == "SYNO.API.Info")
            {
                CgiPath = "query.cgi";
            }
            else
            {
                //Request and Method returns null if the API or the Method is not found.
                var request = api.Connection.ServiceProvider.GetService<IInfoRequest>() as ISynologyRequest;
                request?.MethodAsync<Dictionary<string, IApiInfo>>("query", new object[] { new[] { ApiName } }).ContinueWith(res => 
                {
                    var data = res.Result;
                    //Request and Method returns null if the API or the Method is not found.
                    //If the Info API has returned a value and contains the current API Info, this update the associated cgi.
                    if (data != null && data.Data.ContainsKey(ApiName))
                    {
                        CgiPath = data.Data[ApiName].Path;
                    }
                    else
                    {
                        throw new Exception("The API cannot be found on this Synology. Check if RequestAttribute exists on the relative SynologyRequest subclass or the SYNO.API.Info result.");
                    } 
                });
            }

            Api.Connection.Logger.LogDebug($"Created request {ApiName} to path {CgiPath}");
        }
    }
}
