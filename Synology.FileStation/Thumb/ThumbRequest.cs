using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;

namespace Synology.FileStation.Thumb
{
	public class ThumbRequest : SynologyRequest
	{
		public ThumbRequest(SynologyConnection connection) : base(connection, "FileStation/file_virtual.cgi", "SYNO.FileStation.VirtualFolder")
		{
		}

		public ResultData<byte[]> Get(string path, ThumbSize size = ThumbSize.Small, ThumbRotation rotate = ThumbRotation.Original)
		{
			var additionalParams = new [] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("size", size),
				new QueryStringParameter("rotate", (int)rotate)
			};

			return GetData<byte[]>("get", 1, additionalParams);
		}
	}
}