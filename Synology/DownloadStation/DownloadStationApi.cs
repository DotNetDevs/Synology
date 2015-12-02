using Synology.Classes;

namespace Synology.DownloadStation
{
	public class DownloadStationApi : SynologyApi
	{
		internal DownloadStationApi(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<ScheduleRequest>();
			RegisterRequest<InfoRequest>();
			RegisterRequest<TaskRequest>();

			Schedule = ResolveRequest<ScheduleRequest>();
			Info = ResolveRequest<InfoRequest>();
			Task = ResolveRequest<TaskRequest>();
		}

		public InfoRequest Info { get; private set; }

		public ScheduleRequest Schedule { get; private set; }

		public TaskRequest Task { get; private set; }
	}
}