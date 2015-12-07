using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.FileShare.Results
{
	public class FileListResult
	{
		public int Total { get; set; }

		public int Offset { get; set; }

		public IEnumerable<FileResult> Files { get; set; }
	}
}

