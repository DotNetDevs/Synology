using Synology;
using Synology.DownloadStation2;
using Synology.DownloadStation2.Task;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class DownloadStation2TaskExtension
	{
		/// <summary>
		/// Download Station Task API (Extended)
		/// </summary>
		/// <param name="api"></param>
		/// <returns></returns>
		public static ITaskRequest Task(this DownloadStation2Api api)
		{
			return api.Request<ITaskRequest>();
		}
	}
}
