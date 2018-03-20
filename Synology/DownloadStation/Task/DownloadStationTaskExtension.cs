using Synology;
using Synology.DownloadStation;
using Synology.DownloadStation.Task;

namespace Synology
{
    /// <summary>
    /// Download station task extension.
    /// </summary>
	public static class DownloadStationTaskExtension
	{
        /// <summary>
        /// Task the specified api.
        /// </summary>
        /// <returns>The task.</returns>
        /// <param name="api">API.</param>
		public static ITaskRequest Task(this IDownloadStationApi api)
		{
			return api.Request<ITaskRequest>();
		}
	}
}

