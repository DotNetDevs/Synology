using System;
using Newtonsoft.Json;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderPermResult
	{
		public int Posix { get; set; }

		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

		public VirtualFolderPermAclResult Acl { get; set; }
	}
}