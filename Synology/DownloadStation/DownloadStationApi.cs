using Synology.Classes;
using Synology.DownloadStation.Info;

namespace Synology.DownloadStation
{
	public class DownloadStationApi : SynologyApi
	{
		public DownloadStationApi(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<ScheduleRequest>();
			RegisterRequest<InfoRequest>();
			RegisterRequest<TaskRequest>();

			Schedule = GetRequest<ScheduleRequest>();
			Task = GetRequest<TaskRequest>();
		}


		public ScheduleRequest Schedule { get; private set; }

		public TaskRequest Task { get; private set; }
	}
}