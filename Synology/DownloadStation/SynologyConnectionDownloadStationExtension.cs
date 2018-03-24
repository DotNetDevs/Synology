using Synology;
using Synology.DownloadStation;
using Synology.Interfaces;

namespace Synology
{
    /// <summary>
    /// Synology connection download station extension.
    /// </summary>
    public static class SynologyConnectionDownloadStationExtension
    {
        /// <summary>
        /// Downloads the station.
        /// </summary>
        /// <returns>The station.</returns>
        /// <param name="connection">Connection.</param>
        public static IDownloadStationApi DownloadStation(this ISynologyConnection connection) => connection.Api<IDownloadStationApi>();
    }
}
