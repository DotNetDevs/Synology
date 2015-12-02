using Synology.DownloadStation;
using Synology.DownloadStation.Task;
using Synology.Extensions;

namespace Synology
{
	public static class DownloadStationTaskExtension
	{
		public static TaskRequest Task(this DownloadStationApi api)
		{
			return RequestExtension<TaskRequest>.Request(api);
		}
	}
}

