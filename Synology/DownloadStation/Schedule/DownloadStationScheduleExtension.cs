using Synology.DownloadStation;
using Synology.DownloadStation.Schedule;

namespace Synology
{
	public static class DownloadStationScheduleExtension
	{
		private static ScheduleRequest _schedule;

		public static ScheduleRequest Schedule(this DownloadStationApi api)
		{
			return _schedule ?? (_schedule = api.GetRequest<ScheduleRequest>());
		}
	}
}

