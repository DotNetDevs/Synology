using Synology.DownloadStation;

namespace Synology.ApiContainer
{
	public class DownloadStationApi : BaseApi
	{
		internal DownloadStationApi(SynologyConnection connection) : base(connection)
		{
			Info = new InfoRequest(connection);
			Schedule = new ScheduleRequest(connection);
			Task = new TaskRequest(connection);
		}

		public InfoRequest Info { get; private set; }

		public ScheduleRequest Schedule { get; private set; }

		public TaskRequest Task { get; private set; }
	}
}