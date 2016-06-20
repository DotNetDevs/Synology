using Synology.Attributes;
using Synology.Classes;
using Synology.DownloadStation.Info.Results;
using Synology.DownloadStation.Info.Parameters;
using Synology.Parameters;

namespace Synology.DownloadStation.Info
{
    [Request("Info")]
    public class InfoRequest : DownloadStationRequest
    {
        public InfoRequest(SynologyApi api) : base(api, "info.cgi", "Info")
        {
        }

        [RequestMethod("getinfo")]
        public ResultData<InfoResult> GetInfo()
        {
            return GetData<InfoResult>(new SynologyRequestParameters());
        }

        [RequestMethod("getconfig")]
        public ResultData<ConfigResult> Config()
        {
            return GetData<ConfigResult>(new SynologyRequestParameters { Version = 2 });
        }

        [RequestMethod("setserverconfig")]
        public ResultData SetConfig(SetConfigParameters parameters)
        {
            return GetData(new SynologyRequestParameters
            {
                Version = 2,
                Additional = parameters
            });
        }
    }
}