using Synology.Attributes;
using Synology.Classes;

namespace Synology.VideoStation
{
    [Request("VideoStation")]
    public abstract class VideoStationRequest : SynologyRequest
    {
        protected VideoStationRequest(SynologyApi parentApi) : base(parentApi)
        {
        }
    }
}