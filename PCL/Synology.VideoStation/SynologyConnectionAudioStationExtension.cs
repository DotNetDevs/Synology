using Synology.VideoStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionAudioStationExtension
    {
        public static VideoStationApi VideoStation(this SynologyConnection connection)
        {
            return ApiExtension<VideoStationApi>.Api(connection);
        }
    }
}