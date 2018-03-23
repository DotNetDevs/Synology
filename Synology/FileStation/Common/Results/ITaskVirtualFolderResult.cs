namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task virtual folder result.
    /// </summary>
    public interface ITaskVirtualFolderResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : ITaskResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult>
        where TVirtualFolderAdditionalResult : ITaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>
        where TVirtualFolderOwnerResult : ITaskVirtualFolderOwnerResult
        where TVirtualFolderTimeResult : ITaskVirtualFolderTimeResult
        where TVirtualFolderPermResult : ITaskVirtualFolderPermResult<TVirtualFolderPermAclResult>
        where TVirtualFolderPermAclResult : ITaskVirtualFolderPermAclResult
        where TVirtualFolderVolumeStatusResult : ITaskVirtualFolderVolumeStatusResult
    {
    }
}
