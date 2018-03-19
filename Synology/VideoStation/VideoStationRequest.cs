using Synology.Attributes;
using Synology.Classes;

namespace Synology.VideoStation
{
    [Request("VideoStation")]
    internal abstract class VideoStationRequest : SynologyRequest
    {
        protected VideoStationRequest(IVideoStationApi parentApi) : base(parentApi)
        {
        }
    }
}