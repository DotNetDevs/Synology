using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.MD5.Parameters;
using Synology.FileStation.MD5.Results;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology.FileStation.MD5
{
	[Request("MD5")]
    class MD5Request : FileStationRequest, IMD5Request
	{
        public MD5Request(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("start")]
		public ResultData<MD5StartResult> Start(MD5StartParameters parameters)
		{
			return GetData<MD5StartResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("status")]
		public ResultData<MD5StatusResult> Status(MD5StatusParameters parameters)
		{
			return GetData<MD5StatusResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("stop")]
		public ResultData Stop(MD5StatusParameters parameters)
		{
			return GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}