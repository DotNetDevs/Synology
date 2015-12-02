using Synology.Classes;
using Synology.DownloadStation.Info;
using Synology.DownloadStation.Schedule;
using Synology.DownloadStation.Task;

namespace Synology.DownloadStation
{
	public class DownloadStationApi : SynologyApi
	{
		public DownloadStationApi(SynologyConnection connection) : base(connection)
		{
		}
	}
}