using Synology.FileStation;

namespace Synology.Apis
{
	public class FileStationApi : BaseApi
	{
		internal FileStationApi(SynologyConnection connection) : base(connection)
		{
			Info = new InfoRequest(connection);
		}

		public InfoRequest Info { get; internal set; }
	}
}