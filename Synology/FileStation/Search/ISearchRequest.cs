using System.ComponentModel;
using Synology.Classes;
using Synology.FileStation.FileShare.Parameters;
using Synology.FileStation.Search.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Search
{
    public interface ISearchRequest : ISynologyRequest
    {
        ResultData<StartSearchResult> Start(string folderPath, bool recursive = true, string pattern = null, string extension = null, FileType fileType = FileType.All, long? sizeFrom = null, long? sizeTo = null, long? mTimeFrom = null, long? mTimeTo = null, long? crTimeFrom = null, long? crTimeTo = null, long? aTimeFrom = null, long? aTimeTo = null, string owner = null, string group = null);

        ResultData<SearchListResult> List(string taskId, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, string pattern = null, FileType fileType = FileType.All, FileDetailsType? additional = null);

        ResultData Stop(string[] taskId);

        ResultData Clean(string[] taskId);
    }
}