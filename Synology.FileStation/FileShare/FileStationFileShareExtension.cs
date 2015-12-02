using Synology.FileStation;
using Synology.FileStation.FileShare;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationFileShareExtension
	{
		public static FileShareRequest FileShare(this FileStationApi api)
		{
			return RequestExtension<FileShareRequest>.Request(api);
		}
	}
}