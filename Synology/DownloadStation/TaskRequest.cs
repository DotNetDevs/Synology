using System;
using Synology.Classes;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.DownloadStation
{
	public class TaskRequest : SynologyRequest
	{
		public TaskRequest(SynologyConnection connection) : base(connection, "task.cgi", "SYNO.DownloadStation.Task")
		{
		}

		public ResultData<object> List(int offset = 0, int limit = -1, string additional = null)
		{
			var additionalParams = string.Format("offset={0}&limit={1}&additional={2}", offset, limit, additional);
			var url = GetApiUrl("list", 1, additionalParams);

			return Connection.GetDataFromUrl<object>(url);
		}

		public ResultData<object> Info(string[] ids, string additional = null)
		{
			var additionalParams = string.Format("id={0}&additional={1}", string.Join(",", ids), additional);
			var url = GetApiUrl("getinfo", 1, additionalParams);

			return Connection.GetDataFromUrl<object>(url);
		}

		public ResultData Create(string uri, string file, string username, string password, string unzipPassword, string destination)
		{
			var additionalParams = new List<string>();

			if (!string.IsNullOrWhiteSpace(uri))
			{
				additionalParams.Add(string.Format("uri={0}", uri));
			}

			if (!string.IsNullOrWhiteSpace(file))
			{
				additionalParams.Add(string.Format("file={0}", file));
			}

			if (!string.IsNullOrWhiteSpace(username))
			{
				additionalParams.Add(string.Format("username={0}", username));
			}

			if (!string.IsNullOrWhiteSpace(password))
			{
				additionalParams.Add(string.Format("password={0}", password));
			}

			if (!string.IsNullOrWhiteSpace(unzipPassword))
			{
				additionalParams.Add(string.Format("unzip_password={0}", unzipPassword));
			}

			if (!string.IsNullOrWhiteSpace(destination))
			{
				additionalParams.Add(string.Format("destination={0}", destination));
			}

			var url = GetApiUrl("create", 3, string.Join("&", additionalParams));

			return Connection.GetDataFromUrl(url);
		}

		public ResultData<object> Delete(string[] ids, bool forceComplete)
		{
			var additionalParams = string.Format("id={0}&force_complete={1}", string.Join(",", ids), forceComplete);
			var url = GetApiUrl("delete", 1, additionalParams);

			return Connection.GetDataFromUrl<object>(url);
		}

		public ResultData<object> Pause(string[] ids)
		{
			var additionalParams = string.Format("id={0}", string.Join(",", ids));
			var url = GetApiUrl("pause", 1, additionalParams);

			return Connection.GetDataFromUrl<object>(url);
		}

		public ResultData<object> Resume(string[] ids)
		{
			var additionalParams = string.Format("id={0}", string.Join(",", ids));
			var url = GetApiUrl("resume", 1, additionalParams);

			return Connection.GetDataFromUrl<object>(url);
		}

		public ResultData<object> Edit(string[] ids, string destination = null)
		{
			var additionalParams = new List<string> { string.Format("id={0}", string.Join(",", ids)) };

			if (!string.IsNullOrWhiteSpace(destination))
			{
				additionalParams.Add(string.Format("destination={0}", destination));
			}

			var url = GetApiUrl("edit", 1, string.Join("&", additionalParams));

			return Connection.GetDataFromUrl<object>(url);
		}
	}
}

