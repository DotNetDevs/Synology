using Synology.FileStation;

namespace Synology
{
	public static class SynologyConnectionFileStationExtension
	{
		private static FileStationApi _api;

		public static FileStationApi FileStation(this SynologyConnection connection)
		{
			return _api ?? (_api = connection.GetApi<FileStationApi>());
		}
	}
}
