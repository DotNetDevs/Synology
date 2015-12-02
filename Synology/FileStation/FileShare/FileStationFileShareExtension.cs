using Synology.FileStation;
using Synology.FileStation.FileShare;

namespace Synology
{
	public static class FileStationFileShareExtension
	{
		private static FileShareRequest _fileShare;

		public static FileShareRequest FileShare(this FileStationApi api)
		{
			return _fileShare ?? (_fileShare = api.GetRequest<FileShareRequest>());
		}
	}
}

