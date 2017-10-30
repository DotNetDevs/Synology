using Synology.Attributes;
using Synology.Classes;

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