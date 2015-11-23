using System;
using Newtonsoft.Json;

namespace Synology.FileStation
{
	public class ShareTimeResult
	{
		public DateTime Atime { get; set; }

		public DateTime Mtime { get; set; }

		public DateTime Ctime { get; set; }

		public DateTime CrTime { get; set; }
	}
}