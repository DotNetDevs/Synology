using Synology.FileStation;
using Synology.FileStation.CheckPermission;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationCheckPermissionExtension
	{
		public static CheckPermissionRequest CheckPermission(this FileStationApi api)
		{
			return RequestExtension<CheckPermissionRequest>.Request(api);
		}
	}
}