using Synology.Classes;

namespace Synology.VideoStation
{
    public abstract class AudioStationRequest : SynologyRequest
    {
        protected AudioStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, cgiPath, $"API.AudioStation.{api}")
        {
        }
    }
}