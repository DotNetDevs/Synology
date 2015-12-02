using Synology.Classes;
using Synology.DownloadStation.Info;
using Synology.DownloadStation.Schedule;

namespace Synology.DownloadStation
{
	public class DownloadStationApi : SynologyApi
	{
		public DownloadStationApi(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<ScheduleRequest>();
			RegisterRequest<InfoRequest>();
			RegisterRequest<TaskRequest>();

			Task = GetRequest<TaskRequest>();
		}

		public TaskRequest Task { get; private set; }
	}
}