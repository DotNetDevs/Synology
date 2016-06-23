using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.DirSize.Parameters;
using Synology.FileStation.DirSize.Results;
using Synology.Parameters;

namespace Synology.FileStation.DirSize
{
	[Request("DirSize")]
	public class DirSizeRequest : FileStationRequest
	{
		public DirSizeRequest(SynologyApi api) : base(api)
		{
		}

		[RequestMethod("start")]
		public ResultData<DirSizeStartResult> Start(DirSizeStartParameters parameters)
		{
			return GetData<DirSizeStartResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("status")]
		public ResultData<DirSizeStatusResult> Status(DirSizeStatusParameters parameters)
		{
			return GetData<DirSizeStatusResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("stop")]
		public ResultData Stop(DirSizeStatusParameters parameters)
		{
			return GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}