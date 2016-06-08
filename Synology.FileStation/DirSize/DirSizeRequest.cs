using Synology.Classes;
using Synology.FileStation.DirSize.Parameters;
using Synology.FileStation.DirSize.Results;

namespace Synology.FileStation.DirSize
{
	public class DirSizeRequest : FileStationRequest
	{
		public DirSizeRequest(SynologyApi api) : base(api, "DirSize")
		{
		}

		public ResultData<DirSizeStartResult> Start(DirSizeStartParameters parameters)
		{
			return GetData<DirSizeStartResult>(new SynologyRequestParameters
			{
				Method = "start",
				Additional = parameters
			});
		}

		public ResultData<DirSizeStatusResult> Status(DirSizeStatusParameters parameters)
		{
			return GetData<DirSizeStatusResult>(new SynologyRequestParameters
			{
				Method = "status",
				Additional = parameters
			});
		}

		public ResultData Stop(DirSizeStatusParameters parameters)
		{
			return GetData(new SynologyRequestParameters
			{
				Method = "stop",
				Additional = parameters
			});
		}
	}
}