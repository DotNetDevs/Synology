using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;

namespace Synology.Api.Info
{
    public class InfoRequest : MainApiRequest
    {
        public InfoRequest(SynologyApi api) : base(api, "query.cgi", "Info")
        {
        }

        public ResultData<Dictionary<string, ApiInfoResult>> GetInfo()
        {
            var additionalParams = new[] {
                new QueryStringParameter("query", "all")
            };

            return GetData<Dictionary<string, ApiInfoResult>>(new SynologyRequestParameters
            {
                Method = "query",
                Additional = additionalParams
            });
        }

        public ResultData<Dictionary<string, ApiInfoResult>> GetInfo(params string[] apis)
        {
            var additionalParams = new[] {
                new QueryStringParameter("query", apis)
            };

            return GetData<Dictionary<string, ApiInfoResult>>(new SynologyRequestParameters
            {
                Method = "query",
                Additional = additionalParams
            });
        }
    }
}