﻿using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.FileShare.Parameters;
using Synology.FileStation.Search.Results;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.Search
{
    [Request("Search")]
    internal class SearchRequest : FileStationRequest, ISearchRequest
    {
        public SearchRequest(IFileStationApi api) : base(api)
        {
        }

        #region Obsolete
        [RequestMethod("start")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData<StartSearchResult> Start(string folderPath, bool recursive = true, string pattern = null, string extension = null, FileType fileType = FileType.All, long? sizeFrom = null, long? sizeTo = null, long? mTimeFrom = null, long? mTimeTo = null, long? crTimeFrom = null, long? crTimeTo = null, long? aTimeFrom = null, long? aTimeTo = null, string owner = null, string group = null)
        {
            var additionalParams = new[] {
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

            return this.GetData<StartSearchResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("list")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData<SearchListResult> List(string taskId, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, string pattern = null, FileType fileType = FileType.All, FileDetailsType? additional = null)
        {
            var additionalParams = new[] {
                new QueryStringParameter("additional", additional),
                new QueryStringParameter("taskid", taskId),
                new QueryStringParameter("pattern", pattern),
                new QueryStringParameter("offset", offset),
                new QueryStringParameter("filetype", fileType),
                new QueryStringParameter("limit", limit),
                new QueryStringParameter("sort_by", sortBy),
                new QueryStringParameter("sort_direction", sortDirection)
            };

            return this.GetData<SearchListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("stop")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData Stop(string[] taskId)
        {
            var additionalParams = new[] {
                new QueryStringParameter("taskid", taskId)
            };

            return this.GetData(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("clean")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData Clean(string[] taskId)
        {
            var additionalParams = new[] {
                new QueryStringParameter("taskid", taskId)
            };

            return this.GetData(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }
        #endregion

        [RequestMethod("start")]
        public async Task<ResultData<StartSearchResult>> StartAsync(string folderPath, bool recursive = true, string pattern = null, string extension = null, FileType fileType = FileType.All, long? sizeFrom = null, long? sizeTo = null, long? mTimeFrom = null, long? mTimeTo = null, long? crTimeFrom = null, long? crTimeTo = null, long? aTimeFrom = null, long? aTimeTo = null, string owner = null, string group = null)
        {
            var additionalParams = new[]
            {
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

            return await this.GetDataAsync<StartSearchResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("list")]
        public async Task<ResultData<SearchListResult>> ListAsync(string taskId, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, string pattern = null, FileType fileType = FileType.All, FileDetailsType? additional = null)
        {
            var additionalParams = new[]
            {
                new QueryStringParameter("additional", additional),
                new QueryStringParameter("taskid", taskId),
                new QueryStringParameter("pattern", pattern),
                new QueryStringParameter("offset", offset),
                new QueryStringParameter("filetype", fileType),
                new QueryStringParameter("limit", limit),
                new QueryStringParameter("sort_by", sortBy),
                new QueryStringParameter("sort_direction", sortDirection)
            };

            return await this.GetDataAsync<SearchListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("stop")]
        public async Task<ResultData> StopAsync(string[] taskId)
        {
            var additionalParams = new[]
            {
                new QueryStringParameter("taskid", taskId)
            };

            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("clean")]
        public async Task<ResultData> CleanAsync(string[] taskId)
        {
            var additionalParams = new[]
            {
                new QueryStringParameter("taskid", taskId)
            };

            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }
    }
}

