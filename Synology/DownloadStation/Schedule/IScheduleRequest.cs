using System;
using System.Threading.Tasks;
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
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData<ScheduleResult> Config();

        /// <summary>
        /// Sets the config.
        /// </summary>
        /// <returns>The config.</returns>
        /// <param name="parameters">Parameters.</param>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData SetConfig(SetConfigParameters parameters);

        /// <summary>
        /// Config this instance.
        /// </summary>
        /// <returns>The config.</returns>
        Task<ResultData<ScheduleResult>> ConfigAsync();

        /// <summary>
        /// Sets the config.
        /// </summary>
        /// <returns>The config.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> SetConfigAsync(SetConfigParameters parameters);
    }
}
