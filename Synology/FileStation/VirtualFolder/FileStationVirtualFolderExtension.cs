using Synology.FileStation;
using Synology.FileStation.VirtualFolder;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station virtual folder extension.
    /// </summary>
	public static class FileStationVirtualFolderExtension
	{
        /// <summary>
        /// Virtuals the folder.
        /// </summary>
        /// <returns>The folder.</returns>
        /// <param name="api">API.</param>
		public static IVirtualFolderRequest VirtualFolder(this IFileStationApi api)
		{
			return api.Request<IVirtualFolderRequest>();
		}
	}
}