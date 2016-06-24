using Synology.Attributes;
using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation
{
    [Request("FileStation")]
    public abstract class FileStationRequest : SynologyRequest
    {
        protected FileStationRequest(SynologyApi parentApi) : base(parentApi)
        {
        }
    }
}
