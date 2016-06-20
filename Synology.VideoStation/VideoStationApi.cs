using Synology.Classes;

namespace Synology.VideoStation
{
    public class VideoStationApi : SynologyApi
    {
        public VideoStationApi(SynologyConnection connection) : base(connection)
        {
        }
    }
}