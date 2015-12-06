using Synology.FileStation;
using Synology.FileStation.VirtualFolder;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationVirtualFolderExtension
	{
		public static VirtualFolderRequest VirtualFolder(this FileStationApi api)
		{
			return RequestExtension<VirtualFolderRequest>.Request(api);
		}
	}
}