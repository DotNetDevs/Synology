using Synology.FileStation;
using Synology;
using Synology.Interfaces;

namespace Synology
{
    /// <summary>
    /// Synology connection file station extension.
    /// </summary>
    public static class SynologyConnectionFileStationExtension
    {
        /// <summary>
        /// Files the station.
        /// </summary>
        /// <returns>The station.</returns>
        /// <param name="connection">Connection.</param>
        public static IFileStationApi FileStation(this ISynologyConnection connection) => connection.Api<IFileStationApi>();
    }
}