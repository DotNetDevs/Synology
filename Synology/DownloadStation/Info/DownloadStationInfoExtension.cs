using Synology;
using Synology.DownloadStation;
using Synology.DownloadStation.Info;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class DownloadStationInfoExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="api"></param>
		/// <returns></returns>
		public static IInfoRequest Info(this IDownloadStationApi api)
		{
			return api.Request<IInfoRequest>();
		}
	}
}