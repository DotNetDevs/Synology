using Synology.VideoStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionAudioStationExtension
    {
        public static AudioStationApi AudioStation(this SynologyConnection connection)
        {
            return ApiExtension<AudioStationApi>.Api(connection);
        }
    }
}