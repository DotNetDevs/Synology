using System;
using Synology;
using Synology.DownloadStation.Info;

namespace Synology.DownloadStation
{
	public static class DownloadStationInfoExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this DownloadStationApi api)
		{
			return _info ?? (_info = api.GetRequest<InfoRequest>());
		}
	}
}

