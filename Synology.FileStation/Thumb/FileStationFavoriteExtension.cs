using Synology.FileStation;
using Synology.FileStation.Thumb;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationThumbExtension
	{
		public static ThumbRequest Thumb(this FileStationApi api)
		{
			return RequestExtension<ThumbRequest>.Request(api);
		}
	}
}