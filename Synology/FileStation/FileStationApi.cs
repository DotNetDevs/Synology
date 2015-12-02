using Synology.Classes;

namespace Synology.FileStation
{
	public class FileStationApi : SynologyApi
	{
		internal FileStationApi(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<FileShareRequest>();
			RegisterRequest<InfoRequest>();

			FileShare = ResolveRequest<FileShareRequest>();
			Info = ResolveRequest<InfoRequest>();
		}

		public InfoRequest Info { get; private set; }

		public FileShareRequest FileShare { get; private set; }
	}
}