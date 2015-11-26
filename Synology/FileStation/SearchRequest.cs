using System;
using Synology.Classes;
using Synology.Utilities;
using System.Security.Cryptography.X509Certificates;

namespace Synology.FileStation
{
	public class SearchRequest : SynologyRequest
	{
		internal SearchRequest(SynologyConnection connection) : base(connection, "FileStation/file_find.cgi", "SYNO.FileStation.Search")
		{
		}

		public ResultData<StartSearchResult> Start(string folderPath, bool recursive = true, string pattern = null, string extension = null, string fileType = "all", long? sizeFrom = null, long? sizeTo = null, long? mTimeFrom = null, long? mTimeTo = null, long? crTimeFrom = null, long? crTimeTo = null, long? aTimeFrom = null, long? aTimeTo = null, string owner = null, string group = null)
		{
			var additionalParams = new [] {
				new QueryStringParameter("folder_path", folderPath),
				new QueryStringParameter("recursive", recursive),
				new QueryStringParameter("pattern", pattern),
				new QueryStringParameter("extension", extension),
				new QueryStringParameter("filetype", fileType),
				new QueryStringParameter("size_from", sizeFrom),
				new QueryStringParameter("size_to", sizeTo),
				new QueryStringParameter("mtime_from", mTimeFrom),
				new QueryStringParameter("mtime_to", mTimeTo),
				new QueryStringParameter("crtime_from", crTimeFrom),
				new QueryStringParameter("crtime_to", crTimeTo),
				new QueryStringParameter("atime_from", aTimeFrom),
				new QueryStringParameter("atime_to", aTimeTo),
				new QueryStringParameter("owner", owner),
				new QueryStringParameter("group", group)
			};

			var url = GetApiUrl("list_share", 1, additionalParams);
			return Connection.GetDataFromUrl<StartSearchResult>(url);
		}

		public ResultData<SearchListResult> List(string taskId, int offset = 0, int limit = 0, string sortBy = "name", string sortDirection = "asc", string pattern = null, string fileType = "all", string additional = null)
		{
			var additionalParams = new [] {
				new QueryStringParameter("additional", additional),
				new QueryStringParameter("taskid", taskId),
				new QueryStringParameter("pattern", pattern),
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("filetype", fileType),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("sort_by", sortBy),
				new QueryStringParameter("sort_direction", sortDirection)
			};

			var url = GetApiUrl("list", 1, additionalParams);
			return Connection.GetDataFromUrl<SearchListResult>(url);
		}

		public ResultData Stop(string[] taskId)
		{
			var additionalParams = new [] {
				new QueryStringParameter("taskid", taskId)
			};

			var url = GetApiUrl("stop", 1, additionalParams);
			return Connection.GetDataFromUrl(url);
		}

		public ResultData Clean(string[] taskId)
		{
			var additionalParams = new [] {
				new QueryStringParameter("taskid", taskId)
			};

			var url = GetApiUrl("clean", 1, additionalParams);
			return Connection.GetDataFromUrl(url);
		}
	}
}

