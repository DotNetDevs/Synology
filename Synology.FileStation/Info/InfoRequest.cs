using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Info.Results;
using Synology.Parameters;

namespace Synology.FileStation.Info
{
    public class InfoRequest : FileStationRequest
    {
        public InfoRequest(SynologyApi api) : base(api, "Info")
        {
        }

        [RequestMethod("getinfo")]
        public ResultData<InfoResult> GetInfo()
        {
            return GetData<InfoResult>(new SynologyRequestParameters());
        }
    }
}
