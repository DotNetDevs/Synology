using System;
using Newtonsoft.Json;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderOwnerResult
	{
		public string User { get; set; }

		public string Group { get; set; }

		public int Uid { get; set; }

		public int Gid { get; set; }
	}
}