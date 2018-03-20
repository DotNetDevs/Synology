using Synology.Classes;
using Synology.FileStation.List.Parameters;
using Synology.FileStation.List.Results;
using Synology.Interfaces;

namespace Synology.FileStation.List
{
    /// <summary>
    /// List request.
    /// </summary>
    public interface IListRequest : ISynologyRequest
    {
        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        ResultData<ShareListResult> ListShares(ListSharesParameters parameters);

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        ResultData<FileListResult> ListFiles(ListParameters parameters);

        /// <summary>
        /// Get information of file(s)
        /// </summary>
        /// <returns></returns>
        ResultData<FileInfoResult> GetFileInfo(GetFileInfoParameters parameters);
    }
}