using System.Threading.Tasks;
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
        Task<ResultData<IShareListResult>> ListSharesAsync(ListSharesParameters parameters);

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        Task<ResultData<IFileListResult>> ListFilesAsync(ListParameters parameters);

        /// <summary>
        /// Get information of file(s)
        /// </summary>
        /// <returns></returns>
        Task<ResultData<IFileInfoResult>> GetFileInfoAsync(GetFileInfoParameters parameters);
    }
}