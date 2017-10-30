using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskResult<TAdditionalResult, TOwnerResult, TTimeResult, TPermResult, TPermAclResult>
        where TAdditionalResult : TaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult>, new()
        where TOwnerResult : TaskOwnerResult, new()
        where TTimeResult : TaskTimeResult, new()
        where TPermResult : TaskPermResult<TPermAclResult>, new()
        where TPermAclResult : TaskPermAclResult, new()
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("additional")]
        public TAdditionalResult Additional { get; set; }
    }

    public abstract class TaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult> : TaskResult<TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileListResult : TaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, new()
        where TFileAdditionalResult : TaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, new()
        where TFileOwnerResult : TaskFileOwnerResult, new()
        where TFileTimeResult : TaskFileTimeResult, new()
        where TFilePermResult : TaskFilePermResult<TFilePermAclResult>, new()
        where TFilePermAclResult : TaskFilePermAclResult, new()
        where TFileResult : TaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult>, new()
    {
        [JsonProperty("isdir")]
        public bool IsDir { get; set; }

        [JsonProperty("children")]
        public IEnumerable<TFileListResult> Children { get; set; }
    }

    public class TaskShareResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : TaskResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult>
        where TShareAdditionalResult : TaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>, new()
        where TShareOwnerResult : TaskShareOwnerResult, new()
        where TShareTimeResult : TaskShareTimeResult, new()
        where TSharePermResult : TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>, new()
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TShareVolumeStatusResult : TaskShareVolumeStatusResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
    }

    public class TaskVirtualFolderResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : TaskResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult>
        where TVirtualFolderAdditionalResult : TaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>, new()
        where TVirtualFolderOwnerResult : TaskVirtualFolderOwnerResult, new()
        where TVirtualFolderTimeResult : TaskVirtualFolderTimeResult, new()
        where TVirtualFolderPermResult : TaskVirtualFolderPermResult<TVirtualFolderPermAclResult>, new()
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
        where TVirtualFolderVolumeStatusResult : TaskVirtualFolderVolumeStatusResult, new()
    {
    }
}
