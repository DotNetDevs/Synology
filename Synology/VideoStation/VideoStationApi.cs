using Synology.Classes;
using Synology.Interfaces;

namespace Synology.VideoStation
{
    class VideoStationApi : SynologyApi, IVideoStationApi
    {
        public VideoStationApi(ISynologyConnection connection) : base(connection)
        {
        }
    }
}