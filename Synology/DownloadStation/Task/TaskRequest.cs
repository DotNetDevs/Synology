using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology.DownloadStation.Task
{
	[Request("Task")]
    internal class TaskRequest : DownloadStationRequest, ITaskRequest
	{
		public TaskRequest(IDownloadStationApi api) : base(api)
		{
		}

		[RequestMethod("list")]
		public ResultData<TaskListResult> List(TaskListParameters parameters)
		{
			return GetData<TaskListResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("getinfo")]
		public ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters)
		{
			return GetData<IEnumerable<TaskResult>>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("create")]
		public ResultData Create(TaskCreateParameters parameters)
		{
			return GetData(new SynologyRequestParameters(this)
			{
				Version = 3,
				Additional = parameters
			});
		}

		[RequestMethod("delete")]
		public ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters)
		{
			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("pause")]
		public ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids)
			};

			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

		[RequestMethod("resume")]
		public ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
			};

			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

		[RequestMethod("edit")]
		public ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters)
		{
			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}

