using Synology.Classes;

namespace Synology.VideoStation
{
    public abstract class VideoStationRequest : SynologyRequest
    {
        protected VideoStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, cgiPath, $"API.AudioStation.{api}")
        {
        }
    }
}