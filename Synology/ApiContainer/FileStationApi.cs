using Synology.FileStation;

namespace Synology.ApiContainer
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