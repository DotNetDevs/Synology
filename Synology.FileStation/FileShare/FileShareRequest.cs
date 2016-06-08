using System;
using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;
using System.ComponentModel;
using Synology.FileStation.FileShare.Results;
using Synology.FileStation.FileShare.Parameters;

namespace Synology.FileStation.FileShare
{
	public class FileShareRequest : FileStationRequest
	{
		public FileShareRequest(SynologyApi api) : base(api, "List")
		{
		}

		public ResultData<ShareListResult> ListShare(FileShareDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, bool onlyWritable = false)
		{
			var additionalParams = new[] {
				new QueryStringParameter("additional", additional),
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("sort_by", sortBy),
				new QueryStringParameter("sort_direction", sortDirection),
				new QueryStringParameter("onlywritable", onlyWritable)
			};

			return GetData<ShareListResult>(new SynologyRequestParameters
			{
				Method = "list_share",
				Additional = additionalParams
			});
		}

		public ResultData<FileListResult> List(string folderPath, string pattern = null, FileType fileType = FileType.All, string gotoPath = null, FileDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending)
		{
			var additionalParams = new[] {
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

			return GetData<FileListResult>(new SynologyRequestParameters
			{
				Method = "list",
				Additional = additionalParams
			});
		}

		public ResultData<FileListResult> Info(string path, FileDetailsType? additional = null)
		{
			var additionalParams = new[] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("additional", additional)
			};

			return GetData<FileListResult>(new SynologyRequestParameters
			{
				Method = "getinfo",
				Additional = additionalParams
			});
		}
	}
}

