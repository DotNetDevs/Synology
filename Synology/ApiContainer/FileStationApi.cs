using Synology.FileStation;

namespace Synology.ApiContainer
{
	public class FileStationApi : BaseApi
	{
		internal FileStationApi(SynologyConnection connection) : base(connection)
		{
			Info = new InfoRequest(connection);
			FileShare = new FileShareRequest(connection);
		}

		public InfoRequest Info { get; private set; }

		public FileShareRequest FileShare { get; private set; }
	}
}