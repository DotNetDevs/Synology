using Synology.FileStation;

namespace Synology
{
	public static class SynologyConnectionFileStationExtension
	{
		private static FileStationApi _api;

		public static FileStationApi FileStation(this SynologyConnection connection)
		{
			if (_api == null)
			{
				connection.RegisterApi<FileStationApi>();
				_api = connection.GetApi<FileStationApi>();
			}

			return _api;
		}
	}
}
