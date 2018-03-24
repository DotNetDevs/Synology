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
        Task<ResultData<ITaskListResult>> ListAsync(TaskListParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<ITaskResult>>> InfoAsync(TaskInfoParameters parameters);

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
        Task<ResultData<IEnumerable<ITaskMinimalResult>>> DeleteAsync(TaskDeleteParameters parameters);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<ITaskMinimalResult>>> PauseAsync(params string[] ids);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<ITaskMinimalResult>>> ResumeAsync(params string[] ids);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<ResultData<IEnumerable<ITaskMinimalResult>>> EditAsync(TaskEditParameters parameters);
	}
}
