using Synology.DownloadStation;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionDownloadStationExtension
    {
        public static IDownloadStationApi DownloadStation(this ISynologyConnection connection) => ApiExtension<IDownloadStationApi>.Api(connection);
    }
}
