using System;
using Newtonsoft.Json;

namespace Synology.FileStation.FileShare
{
	public class ShareTimeResult
	{
		public int Atime { get; set; }

		public int Mtime { get; set; }

		public int Ctime { get; set; }

		public int CrTime { get; set; }
	}
}