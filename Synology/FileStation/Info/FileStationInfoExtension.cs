using Synology.FileStation;
using Synology.FileStation.Info;
using Synology;

namespace Synology
{
    /// <summary>
    /// File station info extension.
    /// </summary>
	public static class FileStationInfoExtension
	{
        /// <summary>
        /// Info the specified api.
        /// </summary>
        /// <returns>The info.</returns>
        /// <param name="api">API.</param>
		public static IInfoRequest Info(this IFileStationApi api)
		{
			return api.Request<IInfoRequest>();
		}
	}
}

