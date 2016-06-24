using Synology.Attributes;
using Synology.Classes;

namespace Synology.DownloadStation2
{
    [Request("DownloadStation2")]
    public abstract class DownloadStation2Request : SynologyRequest
    {
        protected DownloadStation2Request(SynologyApi parentApi) : base(parentApi)
        {
        }
    }
}