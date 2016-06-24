using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Search.Results
{
	public class FileOwnerResult
	{
		public string User { get; set; }

		public string Group { get; set; }

		public int Uid { get; set; }

		public int Gid { get; set; }
	}
}