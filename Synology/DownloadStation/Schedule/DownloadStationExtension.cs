using System;
using Synology;
using Synology.DownloadStation.Schedule;

namespace Synology.DownloadStation
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

