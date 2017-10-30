using System;
using Synology.Classes;
using Synology.Utilities;
using System.Collections.Generic;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.FileShare.Results;
using Synology.FileStation.FileShare.Parameters;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology.FileStation.FileShare
{
	[Request("List")]
	internal class FileShareRequest : FileStationRequest, IFileShareRequest
	{
        public FileShareRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("list_share")]
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

			return GetData<ShareListResult>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

		[RequestMethod("list")]
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

			return GetData<FileListResult>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

		[RequestMethod("getinfo")]
		public ResultData<FileListResult> Info(string path, FileDetailsType? additional = null)
		{
			var additionalParams = new[] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("additional", additional)
			};

			return GetData<FileListResult>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}
	}
}

