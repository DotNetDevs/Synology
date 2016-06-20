using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.SurveillanceStation.Info.Results;
using Synology.Parameters;

namespace Synology.SurveillanceStation.Info
{
    [Request("Info")]
    public class InfoRequest : SurveillanceStationRequest
    {
        public InfoRequest(SynologyApi api) : base(api, "info.cgi", "Info")
        {
        }

        [RequestMethod("getinfo")]
        public ResultData<InfoResult> GetInfo()
        {
            return GetData<InfoResult>(new SynologyRequestParameters());
        }
    }
}
