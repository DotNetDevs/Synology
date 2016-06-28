using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.CheckPermission.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.CheckPermission
{
	[Request("CheckPermission")]
	public class CheckPermissionRequest : FileStationRequest
	{
		public CheckPermissionRequest(SynologyApi api) : base(api)
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