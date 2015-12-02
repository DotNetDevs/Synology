using Synology.FileStation;
using Synology.FileStation.Info;

namespace Synology
{
	public static class FileStationInfoExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this FileStationApi api)
		{
			if (_info == null)
			{
				api.RegisterRequest<InfoRequest>();
				_info = api.GetRequest<InfoRequest>();
			}

			return _info;
		}
	}
}

