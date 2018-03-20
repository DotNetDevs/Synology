using Synology.FileStation;
using Synology.FileStation.Info;
using Synology;

namespace Synology
{
	public static class FileStationInfoExtension
	{
		public static IInfoRequest Info(this IFileStationApi api)
		{
			return api.Request<IInfoRequest>();
		}
	}
}

