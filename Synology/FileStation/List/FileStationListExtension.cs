using Synology.FileStation;
using Synology;
using Synology.FileStation.List;

namespace Synology
{
    /// <summary>
    /// File station list extension.
    /// </summary>
	public static class FileStationListExtension
	{
        /// <summary>
        /// List the specified api.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="api">API.</param>
		public static IListRequest List(this IFileStationApi api)
		{
			return api.Request<IListRequest>();
		}
	}
}

