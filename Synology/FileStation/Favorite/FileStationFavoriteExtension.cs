using Synology.FileStation;
using Synology.FileStation.Favorite;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station favorite extension.
    /// </summary>
	public static class FileStationFavoriteExtension
	{
        /// <summary>
        /// Favorite the specified api.
        /// </summary>
        /// <returns>The favorite.</returns>
        /// <param name="api">API.</param>
		public static IFavoriteRequest Favorite(this IFileStationApi api)
		{
			return api.Request<IFavoriteRequest>();
		}
	}
}