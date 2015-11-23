using System;
using Newtonsoft.Json;

namespace Synology.FileStation
{
	public class SharePermResult
	{
		[JsonProperty("share_right")]
		public string ShareRight { get; set; }

		public int Posix { get; set; }

		[JsonProperty("adv_right")]
		public SharePermAdvRightResult AdvRight { get; set; }

		[JsonProperty("acl_enable")]
		public bool AclEnable { get; set; }

		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

		public SharePermAclResult Acl { get; set; }
	}
}