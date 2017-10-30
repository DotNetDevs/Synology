using Synology.Classes;
using Synology.DownloadStation2.Task.Parameters;
using Synology.DownloadStation2.Task.Results;
using Synology.Attributes;
using Synology.Parameters;

namespace Synology.DownloadStation2.Task
{
	/// <summary>
	/// Task (Extended) returning the ids of the downloads.
	/// </summary>
	/// <remarks>
	/// The API is not the same as the normal task request, so a new SynologyRequest has to be created
	/// </remarks>
	[Request("Task")]
    class TaskRequest : DownloadStation2Request, ITaskRequest
	{
        public TaskRequest(IDownloadStation2Api parentApi) : base(parentApi)
		{
		}

		/// <summary>
		/// Create a download by sending the file to the server (usually a torrent file)
		/// </summary>
		/// <param name="parameters">Parameters of the request</param>
		/// <returns>The result of the create task operation with task id and list id if requested.</returns>
		[RequestMethod("create")]
		public ResultData<TaskCreateResult> Create(TaskCreateParameters parameters)
		{
			return PostData<TaskCreateResult>(new SynologyPostParameters(this)
			{
				Additional = parameters
			});
		}
	}
}
