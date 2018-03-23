using System.ComponentModel;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.FileShare.Parameters;
using Synology.FileStation.Search.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Search
{
    /// <summary>
    /// Search request.
    /// </summary>
    public interface ISearchRequest : ISynologyRequest
    {
        /// <summary>
        /// Start the specified folderPath, recursive, pattern, extension, fileType, sizeFrom, sizeTo, mTimeFrom,
        /// mTimeTo, crTimeFrom, crTimeTo, aTimeFrom, aTimeTo, owner and group.
        /// </summary>
        /// <returns>The start.</returns>
        /// <param name="folderPath">Folder path.</param>
        /// <param name="recursive">If set to <c>true</c> recursive.</param>
        /// <param name="pattern">Pattern.</param>
        /// <param name="extension">Extension.</param>
        /// <param name="fileType">File type.</param>
        /// <param name="sizeFrom">Size from.</param>
        /// <param name="sizeTo">Size to.</param>
        /// <param name="mTimeFrom">M time from.</param>
        /// <param name="mTimeTo">M time to.</param>
        /// <param name="crTimeFrom">Cr time from.</param>
        /// <param name="crTimeTo">Cr time to.</param>
        /// <param name="aTimeFrom">A time from.</param>
        /// <param name="aTimeTo">A time to.</param>
        /// <param name="owner">Owner.</param>
        /// <param name="group">Group.</param>
        Task<ResultData<IStartSearchResult>> StartAsync(string folderPath, bool recursive = true, string pattern = null, string extension = null, FileType fileType = FileType.All, long? sizeFrom = null, long? sizeTo = null, long? mTimeFrom = null, long? mTimeTo = null, long? crTimeFrom = null, long? crTimeTo = null, long? aTimeFrom = null, long? aTimeTo = null, string owner = null, string group = null);

        /// <summary>
        /// List the specified taskId, offset, limit, sortBy, sortDirection, pattern, fileType and additional.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="taskId">Task identifier.</param>
        /// <param name="offset">Offset.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="sortBy">Sort by.</param>
        /// <param name="sortDirection">Sort direction.</param>
        /// <param name="pattern">Pattern.</param>
        /// <param name="fileType">File type.</param>
        /// <param name="additional">Additional.</param>
        Task<ResultData<ISearchListResult>> ListAsync(string taskId, int offset = 0, int limit = 0, FileSortType sortBy = FileSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending, string pattern = null, FileType fileType = FileType.All, FileDetailsType? additional = null);

        /// <summary>
        /// Stop the specified taskId.
        /// </summary>
        /// <returns>The stop.</returns>
        /// <param name="taskId">Task identifier.</param>
        Task<ResultData> StopAsync(string[] taskId);

        /// <summary>
        /// Clean the specified taskId.
        /// </summary>
        /// <returns>The clean.</returns>
        /// <param name="taskId">Task identifier.</param>
        Task<ResultData> CleanAsync(string[] taskId);
    }
}