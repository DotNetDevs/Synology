using System;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.DownloadStation.Info.Parameters;
using Synology.DownloadStation.Info.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Info
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public interface IInfoRequest : ISynologyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResultData<IInfoResult>> GetInfoAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResultData<IConfigResult>> ConfigAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData> SetConfigAsync(SetConfigParameters parameters);
    }
}
