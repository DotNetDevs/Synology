using Synology.FileStation;
using Synology.FileStation.FileShare;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station file share extension.
    /// </summary>
	public static class FileStationFileShareExtension
	{
        /// <summary>
        /// Files the share.
        /// </summary>
        /// <returns>The share.</returns>
        /// <param name="api">API.</param>
		public static IFileShareRequest FileShare(this IFileStationApi api)
		{
			return api.Request<IFileShareRequest>();
		}
	}
}