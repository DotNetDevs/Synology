using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.CheckPermission.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.CheckPermission
{
	[Request("CheckPermission")]
	internal class CheckPermissionRequest : FileStationRequest, ICheckPermissionRequest
	{
        public CheckPermissionRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("write")]
		public ResultData Write(CheckPermissionWriteParameters parameters)
		{
			return GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}