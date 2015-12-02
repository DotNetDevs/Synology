using System;
using Synology;
using Synology.DownloadStation.Task;

namespace Synology.DownloadStation
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

