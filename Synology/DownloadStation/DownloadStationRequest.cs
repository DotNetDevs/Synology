using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.DownloadStation
{
    [Request("DownloadStation")]
    internal abstract class DownloadStationRequest : SynologyRequest
    {
        protected DownloadStationRequest(IDownloadStationApi parentApi) : base(parentApi)
        {
        }
    }
}