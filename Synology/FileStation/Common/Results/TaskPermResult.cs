using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskPermResult<TPermAclResult>
        where TPermAclResult : TaskPermAclResult, new()
	{
        [JsonProperty("posix")]
		public int Posix { get; set; }

		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

        [JsonProperty("acl")]
		public TPermAclResult Acl { get; set; }
	}

    public abstract class TaskFilePermResult<TFilePermAclResult> : TaskPermResult<TFilePermAclResult>
        where TFilePermAclResult : TaskFilePermAclResult, new()
    {
    }

    public abstract class TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult> : TaskPermResult<TSharePermAclResult>
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
        [JsonProperty("share_right")]
        public string ShareRight { get; set; }

        [JsonProperty("adv_right")]
        public TSharePermAdvRightResult AdvRight { get; set; }

        [JsonProperty("acl_enable")]
        public bool AclEnable { get; set; }
    }

    public class TaskVirtualFolderPermResult<TVirtualFolderPermAclResult> : TaskPermResult<TVirtualFolderPermAclResult>
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
    {
    }
}