using Synology.AudioStation;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionAudioStationExtension
    {
        public static IAudioStationApi AudioStation(this ISynologyConnection connection) => ApiExtension<IAudioStationApi>.Api(connection);
    }
}