using Synology.FileStation;
using Synology.FileStation.Thumb;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station thumb extension.
    /// </summary>
	public static class FileStationThumbExtension
	{
        /// <summary>
        /// Thumb the specified api.
        /// </summary>
        /// <returns>The thumb.</returns>
        /// <param name="api">API.</param>
		public static IThumbRequest Thumb(this IFileStationApi api)
		{
			return api.Request<IThumbRequest>();
		}
	}
}