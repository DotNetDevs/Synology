using Synology.FileStation;
using Synology.FileStation.DirSize;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station dir size extension.
    /// </summary>
	public static class FileStationDirSizeExtension
	{
        /// <summary>
        /// Thumb the specified api.
        /// </summary>
        /// <returns>The thumb.</returns>
        /// <param name="api">API.</param>
		public static IDirSizeRequest Thumb(this IFileStationApi api)
		{
			return api.Request<IDirSizeRequest>();
		}
	}
}