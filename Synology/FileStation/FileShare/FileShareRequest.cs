using System;
using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;

namespace Synology.FileStation.FileShare
{
	public class FileShareRequest : SynologyRequest
	{
		public FileShareRequest(SynologyConnection connection) : base(connection, "FileStation/file_share.cgi", "SYNO.FileStation.List")
		{
		}

		public ResultData<ShareListResult> ListShare(string additional = null, int offset = 0, int limit = 0, string sortBy = "name", string sortDirection = "asc", bool onlyWritable = false)
		{
			var additionalParams = new [] {
				new QueryStringParameter("additional", additional),
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("sort_by", sortBy),
				new QueryStringParameter("sort_direction", sortDirection),
				new QueryStringParameter("onlywritable", onlyWritable)
			};

			return GetData<ShareListResult>("list_share", 1, additionalParams);
		}

		public ResultData<FileListResult> List(string folderPath, string pattern = null, string fileType = "all", string gotoPath = null, string additional = null, int offset = 0, int limit = 0, string sortBy = "name", string sortDirection = "asc")
		{
			var additionalParams = new [] {
				new QueryStringParameter("additional", additional),
				new QueryStringParameter("folder_path", folderPath),
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("pattern", pattern),
				new QueryStringParameter("filetype", fileType),
				new QueryStringParameter("goto_path", gotoPath),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("sort_by", sortBy),
				new QueryStringParameter("sort_direction", sortDirection)
			};

			return GetData<FileListResult>("list", 1, additionalParams);
		}

		public ResultData<FileListResult> Info(string path, string additional = null)
		{
			var additionalParams = new [] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("additional", additional)
			};

			return GetData<FileListResult>("getinfo", 1, additionalParams);
		}
	}
}

