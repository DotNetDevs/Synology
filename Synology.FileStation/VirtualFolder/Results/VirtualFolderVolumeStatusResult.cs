using System;
using Newtonsoft.Json;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderVolumeStatusResult
	{
		public long FreeSpace { get; set; }

		public long TotalSpace { get; set; }

		public bool Readonly { get; set; }
	}
}