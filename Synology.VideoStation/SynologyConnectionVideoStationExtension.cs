using Synology.VideoStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionVideoStationExtension
    {
        public static VideoStationApi VideoStation(this SynologyConnection connection) => ApiExtension<VideoStationApi>.Api(connection);
    }
}