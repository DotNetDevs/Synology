using Synology;
using Synology.DownloadStation;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionDownloadStationExtension
    {
        public static IDownloadStationApi DownloadStation(this ISynologyConnection connection) => connection.Api<IDownloadStationApi>();
    }
}
