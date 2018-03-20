using Synology;
using Synology.FileStation;
using Synology.FileStation.Rename;

namespace Synology
{
    /// <summary>
    /// File station rename extension.
    /// </summary>
    public static class FileStationRenameExtension
    {
        /// <summary>
        /// Rename the specified api.
        /// </summary>
        /// <returns>The rename.</returns>
        /// <param name="api">API.</param>
        public static IRenameRequest Rename(this IFileStationApi api)
        {
            return api.Request<IRenameRequest>();
        }
    }
}
