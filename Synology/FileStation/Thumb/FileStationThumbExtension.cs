using Synology.FileStation;
using Synology.FileStation.Thumb;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationThumbExtension
	{
		public static IThumbRequest Thumb(this IFileStationApi api)
		{
			return RequestExtension<IThumbRequest>.Request(api);
		}
	}
}