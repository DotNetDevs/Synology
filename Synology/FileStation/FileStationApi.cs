using Synology.Classes;

namespace Synology.FileStation
{
	public class FileStationApi : SynologyApi
	{
		public FileStationApi(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<FileShareRequest>();
			RegisterRequest<InfoRequest>();

			FileShare = GetRequest<FileShareRequest>();
			Info = GetRequest<InfoRequest>();
		}

		public InfoRequest Info { get; private set; }

		public FileShareRequest FileShare { get; private set; }
	}
}