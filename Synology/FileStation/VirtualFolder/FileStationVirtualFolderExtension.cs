using Synology.FileStation;
using Synology.FileStation.VirtualFolder;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationVirtualFolderExtension
	{
		public static IVirtualFolderRequest VirtualFolder(this IFileStationApi api)
		{
			return RequestExtension<IVirtualFolderRequest>.Request(api);
		}
	}
}