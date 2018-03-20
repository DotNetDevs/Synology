using Synology.Classes;
using Synology.DownloadStation.Schedule.Parameters;
using Synology.DownloadStation.Schedule.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Schedule
{
    /// <summary>
    /// Schedule request.
    /// </summary>
    public interface IScheduleRequest : ISynologyRequest
    {
        /// <summary>
        /// Config this instance.
        /// </summary>
        /// <returns>The config.</returns>
        ResultData<ScheduleResult> Config();

        /// <summary>
        /// Sets the config.
        /// </summary>
        /// <returns>The config.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData SetConfig(SetConfigParameters parameters);
    }
}
