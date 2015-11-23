using System;
using Newtonsoft.Json;

namespace Synology.FileStation
{
	public class ShareVolumeStatusResult
	{
		public int FreeSpace { get; set; }

		public int TotalSpace { get; set; }

		public bool Readonly { get; set; }
	}
}