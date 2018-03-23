using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.List.Parameters;
using Synology.FileStation.List.Results;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.List
{
    [Request("List")]
    internal class ListRequest : FileStationRequest, IListRequest
    {
        public ListRequest(IFileStationApi api) : base(api)
        {
        }

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        [RequestMethod("list_share")]
        public async Task<ResultData<IShareListResult>> ListSharesAsync(ListSharesParameters parameters)
        {
            return ResultData<IShareListResult>.From(await this.GetDataAsync<ShareListResult>(new Synology.Parameters.SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters,
            }));
        }

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        [RequestMethod("list")]
        public async Task<ResultData<IFileListResult>> ListFilesAsync(ListParameters parameters)
        {
            return ResultData<IFileListResult>.From(await this.GetDataAsync<FileListResult>(new Synology.Parameters.SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters,
            }));
        }

        /// <summary>
        /// Get information of file(s)
        /// </summary>
        /// <returns></returns>
        [RequestMethod("getinfo")]
        public async Task<ResultData<IFileInfoResult>> GetFileInfoAsync(GetFileInfoParameters parameters)
        {
            return ResultData<IFileInfoResult>.From(await this.GetDataAsync<FileInfoResult>(new Synology.Parameters.SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters,
            }));
        }
    }
}
