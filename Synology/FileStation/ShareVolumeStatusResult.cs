using System;
using Newtonsoft.Json;

namespace Synology.FileStation
{
	public class ShareVolumeStatusResult
	{
		public long FreeSpace { get; set; }

		public long TotalSpace { get; set; }

		public bool Readonly { get; set; }
	}
}