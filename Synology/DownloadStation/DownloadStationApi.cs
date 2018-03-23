using Synology.Classes;
using Synology.Interfaces;

namespace Synology.DownloadStation
{
	/// <inheritdoc cref="SynologyApi" />
	/// <summary>
	/// </summary>
    internal class DownloadStationApi : SynologyApi, IDownloadStationApi
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="connection"></param>
		public DownloadStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}