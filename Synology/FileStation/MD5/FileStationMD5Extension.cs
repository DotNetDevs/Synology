using Synology.FileStation;
using Synology.FileStation.MD5;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationMD5Extension
	{
		public static IMD5Request MD5(this IFileStationApi api)
		{
			return api.Request<IMD5Request>();
		}
	}
}