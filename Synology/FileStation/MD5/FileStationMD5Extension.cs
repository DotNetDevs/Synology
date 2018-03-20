using Synology.FileStation;
using Synology.FileStation.MD5;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station MD 5 extension.
    /// </summary>
	public static class FileStationMD5Extension
	{
        /// <summary>
        /// MD the specified api.
        /// </summary>
        /// <returns>The MD.</returns>
        /// <param name="api">API.</param>
		public static IMD5Request MD5(this IFileStationApi api)
		{
			return api.Request<IMD5Request>();
		}
	}
}