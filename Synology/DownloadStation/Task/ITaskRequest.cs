using System.Collections.Generic;
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
		ResultData<TaskListResult> List(TaskListParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		ResultData Create(TaskCreateParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ids"></param>
		/// <returns></returns>
		ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ids"></param>
		/// <returns></returns>
		ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters);
	}
}
