using Synology;
using Synology.DownloadStation;
using Synology.DownloadStation.Schedule;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class DownloadStationScheduleExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="api"></param>
		/// <returns></returns>
		public static IScheduleRequest Schedule(this IDownloadStationApi api)
		{
			return api.Request<IScheduleRequest>();
		}
	}
}