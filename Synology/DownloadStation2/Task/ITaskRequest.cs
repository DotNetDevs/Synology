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
		ResultData<TaskCreateResult> Create(TaskCreateParameters parameters);
	}
}
