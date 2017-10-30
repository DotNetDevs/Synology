using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult> where TOwnerResult : TaskOwnerResult
        where TTimeResult : TaskTimeResult, new()
        where TPermResult : TaskPermResult<TPermAclResult>, new()
        where TPermAclResult : TaskPermAclResult, new()
    {
        [JsonProperty("real_path")]
        public string RealPath { get; set; }

        [JsonProperty("owner")]
        public TOwnerResult Owner { get; set; }

        [JsonProperty("time")]
        public TTimeResult Time { get; set; }

        [JsonProperty("perm")]
        public TPermResult Perm { get; set; }

        [JsonProperty("mount_point_type")]
        public string MountPointType { get; set; }
    }

    public abstract class TaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : TaskAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileOwnerResult : TaskFileOwnerResult, new()
        where TFileTimeResult : TaskFileTimeResult, new()
        where TFilePermResult : TaskFilePermResult<TFilePermAclResult>, new()
        where TFilePermAclResult : TaskFilePermAclResult, new()
    {
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public abstract class TaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : TaskAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult>
        where TShareOwnerResult : TaskShareOwnerResult, new()
        where TShareTimeResult : TaskShareTimeResult, new()
        where TSharePermResult : TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>, new()
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TShareVolumeStatusResult : TaskShareVolumeStatusResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
        [JsonProperty("volume_status")]
        public TShareVolumeStatusResult VolumeStatus { get; set; }
    }

    public abstract class TaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : TaskAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult>
        where TVirtualFolderOwnerResult : TaskVirtualFolderOwnerResult, new()
        where TVirtualFolderTimeResult : TaskVirtualFolderTimeResult, new()
        where TVirtualFolderPermResult : TaskVirtualFolderPermResult<TVirtualFolderPermAclResult>, new()
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
        where TVirtualFolderVolumeStatusResult : TaskVirtualFolderVolumeStatusResult, new()
    {
        [JsonProperty("volume_status")]
        public TVirtualFolderVolumeStatusResult VolumeStatus { get; set; }
    }
}
