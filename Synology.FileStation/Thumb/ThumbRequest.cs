using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;

namespace Synology.FileStation.Thumb
{
	public class ThumbRequest : SynologyRequest
	{
		public ThumbRequest(SynologyConnection connection) : base(connection, "FileStation/file_thumb.cgi", "SYNO.FileStation.Thumb")
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