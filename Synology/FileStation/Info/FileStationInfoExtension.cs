using Synology.FileStation;
using Synology.FileStation.Info;

namespace Synology
{
	public static class FileStationInfoExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this FileStationApi api)
		{
			return _info ?? (_info = api.GetRequest<InfoRequest>());
		}
	}
}

