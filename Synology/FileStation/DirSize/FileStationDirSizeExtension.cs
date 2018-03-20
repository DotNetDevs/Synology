using Synology.FileStation;
using Synology.FileStation.DirSize;
using Synology;

namespace Synology
{
	public static class FileStationDirSizeExtension
	{
		public static IDirSizeRequest Thumb(this IFileStationApi api)
		{
			return api.Request<IDirSizeRequest>();
		}
	}
}