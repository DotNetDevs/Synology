using System;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.DownloadStation2.Task.Parameters;
using Synology.DownloadStation2.Task.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation2.Task
{
	/// <summary>
	/// 
	/// </summary>
	public interface ITaskRequest : ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<TaskCreateResult> Create(TaskCreateParameters parameters);

        /// <summary>
        /// Creates the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<TaskCreateResult>> CreateAsync(TaskCreateParameters parameters);
	}
}
