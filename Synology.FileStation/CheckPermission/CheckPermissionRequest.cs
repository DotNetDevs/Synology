using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.FileStation.CheckPermission.Parameters;

namespace Synology.FileStation.CheckPermission
{
	public class CheckPermissionRequest : FileStationRequest
	{
		public CheckPermissionRequest(SynologyApi api) : base(api, "CheckPermission")
		{
		}

		public ResultData Write(CheckPermissionWriteParameters parameters)
		{
			return GetData(new SynologyRequestParameters {
				Method = "write",
				Additional = parameters
			});
		}
	}
}