using System;
using Newtonsoft.Json;

namespace Synology.FileStation.FileShare
{
	public class FilePermResult
	{
		public int Posix { get; set; }

		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

		public FilePermAclResult Acl { get; set; }
	}
}