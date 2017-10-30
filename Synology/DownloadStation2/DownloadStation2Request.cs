using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.DownloadStation2
{
    [Request("DownloadStation2")]
    internal abstract class DownloadStation2Request : SynologyRequest
    {
        protected DownloadStation2Request(IDownloadStation2Api parentApi) : base(parentApi)
        {
        }
    }
}