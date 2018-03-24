using Synology;
using Synology.FileStation;
using Synology.FileStation.CheckPermission;

namespace Synology
{
    /// <summary>
    /// File station check permission extension.
    /// </summary>
	public static class FileStationCheckPermissionExtension
	{
        /// <summary>
        /// Checks the permission.
        /// </summary>
        /// <returns>The permission.</returns>
        /// <param name="api">API.</param>
		public static ICheckPermissionRequest CheckPermission(this IFileStationApi api)
		{
			return api.Request<ICheckPermissionRequest>();
		}
	}
}