using System;
using Synology;
using Synology.DownloadStation;

namespace Synology.DownloadStation.Schedule
{
	public static class DownloadStationExtension
	{
		private static ScheduleRequest _schedule;

		public static ScheduleRequest Schedule(this DownloadStationApi api)
		{
			return _schedule ?? (_schedule = api.GetRequest<ScheduleRequest>());
		}
	}
}

