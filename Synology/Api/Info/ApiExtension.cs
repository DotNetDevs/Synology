using System;
using Synology;
using Synology.DownloadStation;

namespace Synology.Api.Info
{
	public static class ApiExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this Api api)
		{
			return _info ?? (_info = api.GetRequest<InfoRequest>());
		}
	}
}

