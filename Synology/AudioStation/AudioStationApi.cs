using Synology.Classes;
using Synology.Interfaces;

namespace Synology.AudioStation
{
    public class AudioStationApi : SynologyApi, IAudioStationApi
    {
        public AudioStationApi(ISynologyConnection connection) : base(connection)
        {
        }
    }
}