using Synology.FileStation;
using Synology.FileStation.DirSize;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationDirSizeExtension
	{
		public static IDirSizeRequest Thumb(this IFileStationApi api)
		{
			return RequestExtension<IDirSizeRequest>.Request(api);
		}
	}
}