using Synology.Classes;
using Synology.Utilities;

namespace Synology.Api
{
	public class InfoRequest : SynologyRequest
	{
		public InfoRequest(SynologyConnection connection) : base(connection, "query.cgi", "SYNO.API.Info")
		{
		}

		public object Info()
		{
			var additionalParams = new QueryStringParameter("query", "all");
			var url = GetApiUrl("query", 1, additionalParams);
			return Connection.GetDataFromUrl<object>(url);
		}
	}
}