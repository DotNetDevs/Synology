using Synology.Attributes;
using Synology.Classes;

namespace Synology.AudioStation
{
    [Request("AudioStation")]
    internal abstract class AudioStationRequest : SynologyRequest
    {
        protected AudioStationRequest(IAudioStationApi parentApi) : base(parentApi)
        {
        }
    }
}