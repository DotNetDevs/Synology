using Synology.DownloadStation;

namespace Synology
{
	public static class SynologyConnectionDownloadStationExtension
	{
		private static DownloadStationApi _api;

		public static DownloadStationApi DownloadStation(this SynologyConnection connection)
		{
			return _api ?? (_api = connection.GetApi<DownloadStationApi>());
		}
	}
}
