using Synology.Classes;
using Synology.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace Synology.DownloadStation.Task
{
	public class TaskRequest : SynologyRequest
	{
		public TaskRequest(SynologyConnection connection) : base(connection, "DownloadStation/task.cgi", "SYNO.DownloadStation.Task")
		{
		}

		public ResultData<TaskListResult> List(TaskDetailsType? additional = null, int offset = 0, int limit = -1)
		{
			var additionalParams = new[] {
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("additional", additional)
			};

			return GetData<TaskListResult>("list", 1, additionalParams);
		}

		public ResultData<IEnumerable<TaskResult>> Info(string[] ids, TaskDetailsType? additional = null)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
				new QueryStringParameter("additional", additional)
			};

			return GetData<IEnumerable<TaskResult>>("getinfo", 1, additionalParams);
		}

		public ResultData Create(string uri, string file, string username, string password, string unzipPassword, string destination)
		{
			var additionalParams = new[] {
				new QueryStringParameter("uri", uri),
				new QueryStringParameter("file", file),
				new QueryStringParameter("username", username),
				new QueryStringParameter("password", password),
				new QueryStringParameter("unzip_password", unzipPassword),
				new QueryStringParameter("destination", destination),
			};

			return GetData("create", 3, additionalParams);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Delete(string[] ids, bool forceComplete)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
				new QueryStringParameter("force_complete", forceComplete)
			};

			return GetData<IEnumerable<TaskMinimalResult>>("delete", 1, additionalParams);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Pause(string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids)
			};

			return GetData<IEnumerable<TaskMinimalResult>>("pause", 1, additionalParams);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Resume(string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
			};

			return GetData<IEnumerable<TaskMinimalResult>>("resume", 1, additionalParams);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Edit(string[] ids, string destination = null)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
				new QueryStringParameter("destination", destination)
			};

			return GetData<IEnumerable<TaskMinimalResult>>("edit", 1, additionalParams);
		}
	}
}

