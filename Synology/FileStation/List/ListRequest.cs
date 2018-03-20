using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.List.Parameters;
using Synology.FileStation.List.Results;

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
		public ResultData<ShareListResult> ListShares(ListSharesParameters parameters)
		{
            return this.GetData<ShareListResult>(new Synology.Parameters.SynologyRequestParameters(this)
			{
				Version = 2,
				Additional = parameters,
			});
		}

		/// <summary>
		/// Enumerate files in a given folder
		/// </summary>
		[RequestMethod("list")]
		public ResultData<FileListResult> ListFiles(ListParameters parameters)
		{
            return this.GetData<FileListResult>(new Synology.Parameters.SynologyRequestParameters(this)
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
		public ResultData<FileInfoResult> GetFileInfo(GetFileInfoParameters parameters)
		{
            return this.GetData<FileInfoResult>(new Synology.Parameters.SynologyRequestParameters(this)
			{
				Version = 2,
				Additional = parameters,
			});
		}
	}
}
