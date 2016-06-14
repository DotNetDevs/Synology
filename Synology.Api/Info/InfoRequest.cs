using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Parameters;

namespace Synology.Api.Info
{
    public class InfoRequest : MainApiRequest
    {
        public InfoRequest(SynologyApi api) : base(api, "query.cgi", "Info")
        {
        }

        [RequestMethod("query")]
        public ResultData<Dictionary<string, ApiInfo>> Query(params string[] apis)
        {
            var additionalParams = new[] {
                apis?.Length > 0 ? new QueryStringParameter("query", apis) : new QueryStringParameter("query", "all")
            };

            return GetData<Dictionary<string, ApiInfo>>(new SynologyRequestParameters
            {
                Additional = additionalParams
            });
        }
    }
}