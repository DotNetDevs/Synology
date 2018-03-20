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
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IInfoResult> GetInfo();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IConfigResult> Config();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData SetConfig(SetConfigParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResultData<IInfoResult>> GetInfoAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
        Task<ResultData<IConfigResult>> ConfigAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
        Task<ResultData> SetConfigAsync(SetConfigParameters parameters);
	}
}
