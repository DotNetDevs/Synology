using Synology.Classes;
using Synology.DownloadStation.Schedule.Parameters;
using Synology.DownloadStation.Schedule.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Schedule
{
    public interface IScheduleRequest : ISynologyRequest
    {
        ResultData<ScheduleResult> Config();

        ResultData SetConfig(SetConfigParameters parameters);
    }
}
