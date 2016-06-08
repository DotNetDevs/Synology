using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;

namespace Synology.Api.Info
{
    public class InfoRequest : MainApiRequest
    {
        public InfoRequest(SynologyApi api) : base(api, "query.cgi", "Info")
        {
        }

        [RequestMethod("query")]
        public ResultData<Dictionary<string, ApiInfoResult>> Query()
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

        [RequestMethod("query")]
        public ResultData<Dictionary<string, ApiInfoResult>> Query(params string[] apis)
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