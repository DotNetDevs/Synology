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
        public ResultData<Dictionary<string, ApiInfoResult>> Query(params string[] apis)
        {
            var additionalParams = new[] {
                apis?.Length > 0 ? new QueryStringParameter("query", apis) : new QueryStringParameter("query", "all")
            };

            return GetData<Dictionary<string, ApiInfoResult>>(new SynologyRequestParameters
            {
                Additional = additionalParams
            });
        }
    }
}