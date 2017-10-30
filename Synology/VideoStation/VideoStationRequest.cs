using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

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