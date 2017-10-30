using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

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