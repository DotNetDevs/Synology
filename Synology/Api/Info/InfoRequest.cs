using Synology.Classes;
using Synology.Utilities;

namespace Synology.Api.Info
{
	public class InfoRequest : SynologyRequest
	{
		public InfoRequest(SynologyConnection connection) : base(connection, "query.cgi", "SYNO.API.Info")
		{
		}

		public object Info()
		{
			var additionalParams = new QueryStringParameter("query", "all");

			return GetData<object>("query", 1, additionalParams);
		}
	}
}