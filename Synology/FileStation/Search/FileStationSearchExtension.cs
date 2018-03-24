using Synology.FileStation;
using Synology.FileStation.Search;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station search extension.
    /// </summary>
	public static class FileStationSearchExtension
	{
        /// <summary>
        /// Search the specified api.
        /// </summary>
        /// <returns>The search.</returns>
        /// <param name="api">API.</param>
		public static ISearchRequest Search(this IFileStationApi api)
		{
			return api.Request<ISearchRequest>();
		}
	}
}