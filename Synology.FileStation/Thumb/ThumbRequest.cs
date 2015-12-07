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

		public ResultData<byte[]> Get(string path, ThumbSize size = ThumbSize.Small, ThumbRotation rotate = ThumbRotation.Original)
		{
			var additionalParams = new[] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("size", size),
				new QueryStringParameter("rotate", (int)rotate)
			};

			return GetData<byte[]>(new SynologyRequestParameters
			{
				Method = "get",
				Additional = additionalParams
			});
		}
	}
}