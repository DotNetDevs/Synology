using Synology.FileStation;
using Synology.FileStation.Info;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationInfoExtension
	{
		public static InfoRequest Info(this FileStationApi api)
		{
			return RequestExtension<InfoRequest>.Request(api);
		}
	}
}

