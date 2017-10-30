using Synology.Attributes;
using Synology.Classes;

namespace Synology.FileStation
{
    [Request("FileStation")]
    internal abstract class FileStationRequest : SynologyRequest
    {
        protected FileStationRequest(IFileStationApi parentApi) : base(parentApi)
        {
        }
    }
}
