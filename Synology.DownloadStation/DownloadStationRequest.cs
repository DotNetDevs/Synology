using Synology.Classes;

namespace Synology.DownloadStation
{
	public abstract class DownloadStationRequest : ApiRequest
	{
		protected DownloadStationRequest(SynologyConnection connection, string cgiPath, string api) : base(connection, $"DownloadStation/{cgiPath}", $"DownloadStation.{api}")
		{
		}
	}
}