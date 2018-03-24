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
        Task<ResultData<IScheduleResult>> ConfigAsync();

        /// <summary>
        /// Sets the config.
        /// </summary>
        /// <returns>The config.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> SetConfigAsync(SetConfigParameters parameters);
    }
}
