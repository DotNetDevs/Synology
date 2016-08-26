using Synology.Classes;

namespace Synology.DownloadStation
{
	public class DownloadStationApi : SynologyApi
	{
		public DownloadStationApi(SynologyConnection connection) : base(connection)
		{
		}
	}
}