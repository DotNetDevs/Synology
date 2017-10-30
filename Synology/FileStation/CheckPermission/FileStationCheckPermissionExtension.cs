using Synology.FileStation;
using Synology.FileStation.CheckPermission;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationCheckPermissionExtension
	{
		public static ICheckPermissionRequest CheckPermission(this IFileStationApi api)
		{
			return api.Request<ICheckPermissionRequest>();
		}
	}
}