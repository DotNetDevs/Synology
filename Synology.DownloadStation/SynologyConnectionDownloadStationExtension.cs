using Synology.DownloadStation;

namespace Synology
{
	public static class SynologyConnectionDownloadStationExtension
	{
		private static DownloadStationApi _api;

		public static DownloadStationApi DownloadStation(this SynologyConnection connection)
		{
			if (_api == null)
			{
				connection.RegisterApi<DownloadStationApi>();
				_api = connection.GetApi<DownloadStationApi>();
			}

			return _api;
		}
	}
}
