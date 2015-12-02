using Synology.Classes;
using Synology.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace Synology.DownloadStation
{
	public class TaskRequest : SynologyRequest
	{
		public TaskRequest(SynologyConnection connection) : base(connection, "DownloadStation/task.cgi", "SYNO.DownloadStation.Task")
		{
		}

		public ResultData<TaskListResult> List(string additional = null, int offset = 0, int limit = -1)
		{
			var additionalParams = new[] {
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("additional", additional)
			};
			var url = GetApiUrl("list", 1, additionalParams);

			return Connection.GetDataFromUrl<TaskListResult>(url);
		}

		public ResultData<IEnumerable<TaskResult>> Info(string[] ids, string additional = null)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
				new QueryStringParameter("additional", additional)
			};
			var url = GetApiUrl("getinfo", 1, additionalParams);

			return Connection.GetDataFromUrl<IEnumerable<TaskResult>>(url);
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

			var url = GetApiUrl("create", 3, additionalParams);

			return Connection.GetDataFromUrl(url);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Delete(string[] ids, bool forceComplete)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
				new QueryStringParameter("force_complete", forceComplete)
			};
			var url = GetApiUrl("delete", 1, additionalParams);

			return Connection.GetDataFromUrl<IEnumerable<TaskMinimalResult>>(url);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Pause(string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids)
			};
			var url = GetApiUrl("pause", 1, additionalParams);

			return Connection.GetDataFromUrl<IEnumerable<TaskMinimalResult>>(url);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Resume(string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
			};
			var url = GetApiUrl("resume", 1, additionalParams);

			return Connection.GetDataFromUrl<IEnumerable<TaskMinimalResult>>(url);
		}

		public ResultData<IEnumerable<TaskMinimalResult>> Edit(string[] ids, string destination = null)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
				new QueryStringParameter("destination", destination)
			};

			var url = GetApiUrl("edit", 1, additionalParams);

			return Connection.GetDataFromUrl<IEnumerable<TaskMinimalResult>>(url);
		}
	}
}

