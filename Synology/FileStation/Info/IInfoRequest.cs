using System;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.Info.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Info
{
    /// <summary>
    /// Info request.
    /// </summary>
    public interface IInfoRequest : ISynologyRequest
    {
        /// <summary>
        /// Get this instance.
        /// </summary>
        /// <returns>The get.</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData<InfoResult> Get();

        /// <summary>
        /// Get this instance.
        /// </summary>
        /// <returns>The get.</returns>
        Task<ResultData<InfoResult>> GetAsync();
    }
}
