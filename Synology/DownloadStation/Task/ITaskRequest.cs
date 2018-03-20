using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Task
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	public interface ITaskRequest : ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<TaskListResult> List(TaskListParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData Create(TaskCreateParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ids"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ids"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData<TaskListResult>> ListAsync(TaskListParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<TaskResult>>> InfoAsync(TaskInfoParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData> CreateAsync(TaskCreateParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<TaskMinimalResult>>> DeleteAsync(TaskDeleteParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<TaskMinimalResult>>> PauseAsync(params string[] ids);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<TaskMinimalResult>>> ResumeAsync(params string[] ids);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<TaskMinimalResult>>> EditAsync(TaskEditParameters parameters);
	}
}
