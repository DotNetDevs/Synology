using Synology.FileStation;
using Synology.FileStation.Favorite;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationFavoriteExtension
	{
		public static FavoriteRequest Favorite(this FileStationApi api)
		{
			return RequestExtension<FavoriteRequest>.Request(api);
		}
	}
}