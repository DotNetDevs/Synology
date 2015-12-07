using System;
using Newtonsoft.Json;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderTimeResult
	{
		public int Atime { get; set; }

		public int Mtime { get; set; }

		public int Ctime { get; set; }

		public int CrTime { get; set; }
	}
}