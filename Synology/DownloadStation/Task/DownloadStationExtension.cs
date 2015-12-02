using System;
using Synology;
using Synology.DownloadStation;

namespace Synology.DownloadStation.Task
{
	public static class DownloadStationExtension
	{
		private static TaskRequest _task;

		public static TaskRequest Task(this DownloadStationApi api)
		{
			return _task ?? (_task = api.GetRequest<TaskRequest>());
		}
	}
}

