using Synology.DownloadStation;
using Synology.DownloadStation.Schedule;
using Synology.Extensions;

namespace Synology
{
	public static class DownloadStationScheduleExtension
	{
		public static ScheduleRequest Schedule(this DownloadStationApi api)
		{
			return RequestExtension<ScheduleRequest>.Request(api);
		}
	}
}