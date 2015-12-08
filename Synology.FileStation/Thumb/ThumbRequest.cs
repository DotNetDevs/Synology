using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.FileStation.Thumb.Parameters;

namespace Synology.FileStation.Thumb
{
	public class ThumbRequest : FileStationRequest
	{
		public ThumbRequest(SynologyApi api) : base(api, "file_thumb.cgi", "Thumb")
		{
		}

		public ResultData<byte[]> Get(ThumbGetParameters parameters)
		{
			return GetData<byte[]>(new SynologyRequestParameters {
				Method = "get",
				Additional = parameters
			});
		}
	}
}