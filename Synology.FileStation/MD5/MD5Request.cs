using Synology.Classes;
using Synology.FileStation.MD5.Parameters;
using Synology.FileStation.MD5.Results;

namespace Synology.FileStation.MD5
{
	public class MD5Request : FileStationRequest
	{
		public MD5Request(SynologyApi api) : base(api, "file_md5.cgi", "MD5")
		{
		}

		public ResultData<MD5StartResult> Start(MD5StartParameters parameters)
		{
			return GetData<MD5StartResult>(new SynologyRequestParameters
			{
				Method = "start",
				Additional = parameters
			});
		}

		public ResultData<MD5StatusResult> Status(MD5StatusParameters parameters)
		{
			return GetData<MD5StatusResult>(new SynologyRequestParameters
			{
				Method = "status",
				Additional = parameters
			});
		}

		public ResultData Stop(MD5StatusParameters parameters)
		{
			return GetData(new SynologyRequestParameters
			{
				Method = "stop",
				Additional = parameters
			});
		}
	}
}