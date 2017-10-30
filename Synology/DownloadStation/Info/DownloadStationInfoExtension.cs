using Synology.DownloadStation;
using Synology.DownloadStation.Info;
using Synology.Extensions;

namespace Synology
{
	public static class DownloadStationInfoExtension
	{
		public static IInfoRequest Info(this IDownloadStationApi api)
		{
			return RequestExtension<IInfoRequest>.Request(api);
		}
	}
}