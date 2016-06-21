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
        public ListRequest(SynologyApi api) : base(api, "List")
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
        public ResultData ListFiles()
        {
            throw new NotImplementedException();
        }
        [RequestMethod("getinfo")]
        public ResultData GetFileInfo()
        {
            throw new NotImplementedException();
        }
    }
}
