using Synology.Classes;
using Synology.Interfaces;

namespace Synology.DownloadStation
{
	public class DownloadStationApi : SynologyApi, IDownloadStationApi
	{
		public DownloadStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}