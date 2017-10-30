using Synology.FileStation;
using Synology.FileStation.Favorite;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationFavoriteExtension
	{
		public static IFavoriteRequest Favorite(this IFileStationApi api)
		{
			return api.Request<IFavoriteRequest>();
		}
	}
}