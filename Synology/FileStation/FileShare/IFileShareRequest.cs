using System.ComponentModel;
using Synology.Classes;
using Synology.FileStation.FileShare.Parameters;
using Synology.FileStation.FileShare.Results;
using Synology.Interfaces;

namespace Synology.FileStation.FileShare
{
    public interface IFileShareRequest : ISynologyRequest
    {
        ResultData<ShareListResult> ListShare(FileShareDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, bool onlyWritable = false);

        ResultData<FileListResult> List(string folderPath, string pattern = null, FileType fileType = FileType.All, string gotoPath = null, FileDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending);

        ResultData<FileListResult> Info(string path, FileDetailsType? additional = null);
    }
}