using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.CheckPermission.Parameters;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.CheckPermission
{
	[Request("CheckPermission")]
	internal class CheckPermissionRequest : FileStationRequest, ICheckPermissionRequest
	{
        public CheckPermissionRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("write")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData Write(CheckPermissionWriteParameters parameters)
		{
            return this.GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

        [RequestMethod("write")]
        public async Task<ResultData> WriteAsync(CheckPermissionWriteParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
	}
}