using Synology.Attributes;
using Synology.Classes;

namespace Synology.VideoStation
{
    [Request("AudioStation")]
    public abstract class AudioStationRequest : SynologyRequest
    {
        protected AudioStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, cgiPath, $"AudioStation.{api}")
        {
        }
    }
}