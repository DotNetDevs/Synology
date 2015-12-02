using System;
using Synology;
using Synology.DownloadStation;

namespace Synology.DownloadStation.Info
{
	public static class DownloadStationExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this DownloadStationApi api)
		{
			return _info ?? (_info = api.GetRequest<InfoRequest>());
		}
	}
}

