using Synology.Classes;
using Synology.Utilities;

namespace Synology.Api.Info
{
	public class InfoRequest : MainApiRequest
	{
		public InfoRequest(SynologyApi api) : base(api, "query.cgi", "Info")
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