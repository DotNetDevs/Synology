using Synology.DownloadStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionDownloadStationExtension
    {
        public static DownloadStationApi DownloadStation(this SynologyConnection connection) => ApiExtension<DownloadStationApi>.Api(connection);
    }
}
