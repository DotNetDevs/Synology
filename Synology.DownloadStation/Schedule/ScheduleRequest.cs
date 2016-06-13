using Synology.Attributes;
using Synology.Classes;
using Synology.DownloadStation.Schedule.Parameters;
using Synology.DownloadStation.Schedule.Results;

namespace Synology.DownloadStation.Schedule
{
    public class ScheduleRequest : DownloadStationRequest
    {
        public ScheduleRequest(SynologyApi api) : base(api, "schedule.cgi", "Schedule")
        {
        }

        [RequestMethod("getconfig")]
        public ResultData<ScheduleResult> Config()
        {
            return GetData<ScheduleResult>(new SynologyRequestParameters());
        }

        [RequestMethod("setserverconfig")]
        public ResultData SetConfig(SetConfigParameters parameters)
        {
            return GetData(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }
    }
}

