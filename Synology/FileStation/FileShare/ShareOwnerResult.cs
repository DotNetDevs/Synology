using System;
using Newtonsoft.Json;

namespace Synology.FileStation.FileShare
{
	public class ShareOwnerResult
	{
		public string User { get; set; }

		public string Group { get; set; }

		public int Uid { get; set; }

		public int Gid { get; set; }
	}
}