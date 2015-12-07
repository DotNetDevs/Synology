using Synology.Classes;
using Synology.Utilities;

namespace Synology.Api.Info
{
	public class InfoRequest : SynologyRequest
	{
		public InfoRequest(SynologyConnection connection) : base(connection, "query.cgi", "SYNO.API.Info")
		{
		}

		public object GetInfo()
		{
			var additionalParams = new[] {
				new QueryStringParameter("query", "all")
			};

			return GetData<object>(new SynologyRequestParameters
			{
				Method = "query",
				Additional = additionalParams
			});
		}
	}
}