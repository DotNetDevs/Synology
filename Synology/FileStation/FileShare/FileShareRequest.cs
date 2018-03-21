using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.FileShare.Results;
using Synology.FileStation.FileShare.Parameters;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.FileShare
{
    [Request("List")]
    internal class FileShareRequest : FileStationRequest, IFileShareRequest
    {
        public FileShareRequest(IFileStationApi api) : base(api)
        {
        }

        #region Obsolete
        [RequestMethod("list_share")]
        [Obsolete("It uses Result, migrate to Async methods")]
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

            return this.GetData<ShareListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("list")]
        [Obsolete("It uses Result, migrate to Async methods")]
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

            return this.GetData<FileListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("getinfo")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData<FileListResult> Info(string path, FileDetailsType? additional = null)
        {
            var additionalParams = new[] {
                new QueryStringParameter("path", path),
                new QueryStringParameter("additional", additional)
            };

            return this.GetData<FileListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }
        #endregion

        [RequestMethod("list_share")]
        public async Task<ResultData<ShareListResult>> ListShareAsync(FileShareDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, bool onlyWritable = false)
        {
            var additionalParams = new[] {
                new QueryStringParameter("additional", additional),
                new QueryStringParameter("offset", offset),
                new QueryStringParameter("limit", limit),
                new QueryStringParameter("sort_by", sortBy),
                new QueryStringParameter("sort_direction", sortDirection),
                new QueryStringParameter("onlywritable", onlyWritable)
            };

            return await this.GetDataAsync<ShareListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("list")]
        public async Task<ResultData<FileListResult>> ListAsync(string folderPath, string pattern = null, FileType fileType = FileType.All, string gotoPath = null, FileDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending)
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

            return await this.GetDataAsync<FileListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("getinfo")]
        public async Task<ResultData<FileListResult>> InfoAsync(string path, FileDetailsType? additional = null)
        {
            var additionalParams = new[] {
                new QueryStringParameter("path", path),
                new QueryStringParameter("additional", additional)
            };

            return await this.GetDataAsync<FileListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }
    }
}

