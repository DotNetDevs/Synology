using Synology.FileStation;
using Synology.FileStation.FileShare;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationFileShareExtension
	{
		public static IFileShareRequest FileShare(this IFileStationApi api)
		{
			return api.Request<IFileShareRequest>();
		}
	}
}