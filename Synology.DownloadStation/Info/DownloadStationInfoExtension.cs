using Synology.DownloadStation;
using Synology.DownloadStation.Info;
using Synology.Extensions;

namespace Synology
{
	public static class DownloadStationInfoExtension
	{
		public static InfoRequest Info(this DownloadStationApi api)
		{
			return RequestExtension<InfoRequest>.Request(api);
		}
	}
}