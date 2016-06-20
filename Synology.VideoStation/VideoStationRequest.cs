using Synology.Attributes;
using Synology.Classes;

namespace Synology.VideoStation
{
    [Request("VideoStation")]
    public abstract class VideoStationRequest : SynologyRequest
    {
        protected VideoStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, cgiPath, $"VideoStation.{api}")
        {
        }
    }
}