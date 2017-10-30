using Synology.DownloadStation;
using Synology.DownloadStation.Schedule;
using Synology.Extensions;

namespace Synology
{
	public static class DownloadStationScheduleExtension
	{
		public static IScheduleRequest Schedule(this IDownloadStationApi api)
		{
			return RequestExtension<IScheduleRequest>.Request(api);
		}
	}
}