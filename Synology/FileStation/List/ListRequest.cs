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
        public async Task<ResultData<ShareListResult>> ListSharesAsync(ListSharesParameters parameters)
        {
            return await this.GetDataAsync<ShareListResult>(new Synology.Parameters.SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters,
            });
        }

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        [RequestMethod("list")]
        public async Task<ResultData<FileListResult>> ListFilesAsync(ListParameters parameters)
        {
            return await this.GetDataAsync<FileListResult>(new Synology.Parameters.SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters,
            });
        }

        /// <summary>
        /// Get information of file(s)
        /// </summary>
        /// <returns></returns>
        [RequestMethod("getinfo")]
        public async Task<ResultData<FileInfoResult>> GetFileInfoAsync(GetFileInfoParameters parameters)
        {
            return await this.GetDataAsync<FileInfoResult>(new Synology.Parameters.SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters,
            });
        }
    }
}
