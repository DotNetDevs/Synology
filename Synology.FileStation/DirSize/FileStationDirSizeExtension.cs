using Synology.FileStation;
using Synology.FileStation.DirSize;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationDirSizeExtension
	{
		public static DirSizeRequest Thumb(this FileStationApi api)
		{
			return RequestExtension<DirSizeRequest>.Request(api);
		}
	}
}