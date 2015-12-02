using Synology.DownloadStation;
using Synology.DownloadStation.Task;

namespace Synology
{
	public static class DownloadStationTaskExtension
	{
		private static TaskRequest _task;

		public static TaskRequest Task(this DownloadStationApi api)
		{
			if (_task == null)
			{
				api.RegisterRequest<TaskRequest>();
				_task = api.GetRequest<TaskRequest>();
			}

			return _task;
		}
	}
}

