using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Parameters;
using Microsoft.Extensions.Logging;

namespace Synology.Api.Info
{
	[Request("Info")]
	public class InfoRequest : MainApiRequest
	{
		public InfoRequest(SynologyApi api) : base(api)
		{
		}

		[RequestMethod("query")]
		public ResultData<Dictionary<string, ApiInfo>> Query(params string[] apis)
		{
			Api.Connection.Logger.LogDebug($"Requesting Info for {(apis.Length > 0 ? string.Join(";", apis) : "all")} APIs");

			var additionalParams = new[] {
				apis.Length > 0 ? new QueryStringParameter("query", apis) : new QueryStringParameter("query", "all")
			};

			return GetData<Dictionary<string, ApiInfo>>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}
	}
}