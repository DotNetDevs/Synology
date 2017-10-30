using Synology.DownloadStation;
using Synology.DownloadStation.Task;
using Synology.Extensions;

namespace Synology
{
	public static class DownloadStationTaskExtension
	{
		public static ITaskRequest Task(this IDownloadStationApi api)
		{
			return RequestExtension<ITaskRequest>.Request(api);
		}
	}
}

