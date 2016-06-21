using System;
using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.List.Parameters;
using Synology.FileStation.List.Results;

namespace Synology.FileStation.List
{
    [Request("List")]
    public class ListRequest : FileStationRequest
    {
        public ListRequest(SynologyApi api) : base(api)
        {
        }

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        [RequestMethod("list_share")]
        public ResultData<ListSharesResult> ListShares(ListSharesParameters parameters)
        {
            return GetData<ListSharesResult>(new Synology.Parameters.SynologyRequestParameters
            {
                Version = 2,
                Additional = parameters,
            });
        }

        /// <summary>
        /// Enumerate files in a given folder
        /// </summary>
        [RequestMethod("list")]
        public ResultData<ListResult> ListFiles(ListParameters parameters)
        {
            return GetData<ListResult>(new Synology.Parameters.SynologyRequestParameters
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
        public ResultData<GetFileInfoResult> GetFileInfo(GetFileInfoParameters parameters)
        {
            return GetData<GetFileInfoResult>(new Synology.Parameters.SynologyRequestParameters
            {
                Version = 2,
                Additional = parameters,
            });
        }
    }
}
