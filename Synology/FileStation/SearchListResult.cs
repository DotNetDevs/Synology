using System;
using System.Collections.Generic;

namespace Synology.FileStation
{
	public class SearchListResult
	{
		public int Total { get; set; }

		public int Offset { get; set; }

		public bool Finished { get; set; }

		public IEnumerable<FileResult> Files { get; set; }
	}
}

