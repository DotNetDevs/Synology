using Synology.Attributes;
using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Interfaces;

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
