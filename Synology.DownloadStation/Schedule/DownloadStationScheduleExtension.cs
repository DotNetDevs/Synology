using Synology.DownloadStation;
using Synology.DownloadStation.Schedule;

namespace Synology
{
	public static class DownloadStationScheduleExtension
	{
		private static ScheduleRequest _schedule;

		public static ScheduleRequest Schedule(this DownloadStationApi api)
		{
			if (_schedule == null)
			{
				api.RegisterRequest<ScheduleRequest>();
				_schedule = api.GetRequest<ScheduleRequest>();
			}

			return _schedule;
		}
	}
}

