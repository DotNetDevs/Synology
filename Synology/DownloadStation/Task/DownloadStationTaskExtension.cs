using Synology;
using Synology.DownloadStation;
using Synology.DownloadStation.Task;

namespace Synology
{
	public static class DownloadStationTaskExtension
	{
		public static ITaskRequest Task(this IDownloadStationApi api)
		{
			return api.Request<ITaskRequest>();
		}
	}
}

