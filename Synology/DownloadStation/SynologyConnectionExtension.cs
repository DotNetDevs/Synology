namespace Synology.DownloadStation
{
	public static class SynologyConnectionExtension
	{
		private static DownloadStationApi _api;
		public static DownloadStationApi DownloadStation(this SynologyConnection connection)
		{
			return _api ?? (_api = connection.GetApi<DownloadStationApi>());
		}
	}
}
