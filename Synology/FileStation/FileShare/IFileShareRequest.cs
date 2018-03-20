using System.ComponentModel;
using Synology.Classes;
using Synology.FileStation.FileShare.Parameters;
using Synology.FileStation.FileShare.Results;
using Synology.Interfaces;

namespace Synology.FileStation.FileShare
{
    /// <summary>
    /// File share request.
    /// </summary>
    public interface IFileShareRequest : ISynologyRequest
    {
        /// <summary>
        /// Lists the share.
        /// </summary>
        /// <returns>The share.</returns>
        /// <param name="additional">Additional.</param>
        /// <param name="offset">Offset.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="sortBy">Sort by.</param>
        /// <param name="sortDirection">Sort direction.</param>
        /// <param name="onlyWritable">If set to <c>true</c> only writable.</param>
        ResultData<ShareListResult> ListShare(FileShareDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, bool onlyWritable = false);

        /// <summary>
        /// List the specified folderPath, pattern, fileType, gotoPath, additional, offset, limit, sortBy and sortDirection.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="folderPath">Folder path.</param>
        /// <param name="pattern">Pattern.</param>
        /// <param name="fileType">File type.</param>
        /// <param name="gotoPath">Goto path.</param>
        /// <param name="additional">Additional.</param>
        /// <param name="offset">Offset.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="sortBy">Sort by.</param>
        /// <param name="sortDirection">Sort direction.</param>
        ResultData<FileListResult> List(string folderPath, string pattern = null, FileType fileType = FileType.All, string gotoPath = null, FileDetailsType? additional = null, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending);

        /// <summary>
        /// Info the specified path and additional.
        /// </summary>
        /// <returns>The info.</returns>
        /// <param name="path">Path.</param>
        /// <param name="additional">Additional.</param>
        ResultData<FileListResult> Info(string path, FileDetailsType? additional = null);
    }
}