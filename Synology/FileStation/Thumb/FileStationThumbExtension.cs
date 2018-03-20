using Synology.FileStation;
using Synology.FileStation.Thumb;
using Synology;

namespace Synology
{
	public static class FileStationThumbExtension
	{
		public static IThumbRequest Thumb(this IFileStationApi api)
		{
			return api.Request<IThumbRequest>();
		}
	}
}