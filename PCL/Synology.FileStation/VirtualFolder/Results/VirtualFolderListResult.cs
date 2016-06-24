using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderListResult
	{
		public int Total { get; set; }

		public int Offset { get; set; }

		public IEnumerable<VirtualFolderResult> Folders { get; set; }
	}
}

