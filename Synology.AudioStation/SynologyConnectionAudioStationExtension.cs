using Synology.VideoStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionAudioStationExtension
    {
        public static AudioStationApi AudioStation(this SynologyConnection connection) => ApiExtension<AudioStationApi>.Api(connection);
    }
}