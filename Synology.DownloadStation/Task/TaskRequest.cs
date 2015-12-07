using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace Synology.DownloadStation.Task
{
	public class TaskRequest : DownloadStationRequest
	{
		public TaskRequest(SynologyApi api) : base(api, "task.cgi", "Task")
		{
		}

		public ResultData<TaskListResult> List(TaskListParameters parameters)
		{
			return GetData<TaskListResult>(new SynologyRequestParameters
			{
				Method = "list",
				Additional = parameters
			});
		}

		public ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters)
		{
			return GetData<IEnumerable<TaskResult>>(new SynologyRequestParameters
			{
				Method = "getinfo",
				Additional = parameters
			});
		}

		public ResultData Create(TaskCreateParameters parameters)
		{
			return GetData(new SynologyRequestParameters
			{
				Method = "create",
				Version = 3,
				Additional = parameters
			});
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters)
		{
			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
			{
				Method = "delete",
				Additional = parameters
			});
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids)
			};

			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
			{
				Method = "pause",
				Additional = additionalParams
			});
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
			};

			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
			{
				Method = "resume",
				Additional = additionalParams
			});
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters)
		{
			return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
			{
				Method = "edit",
				Additional = parameters
			});
		}
	}
}

