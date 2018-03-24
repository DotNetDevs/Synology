namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task virtual folder additional result.
    /// </summary>
    public interface ITaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : ITaskAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult>
        where TVirtualFolderOwnerResult : ITaskVirtualFolderOwnerResult
        where TVirtualFolderTimeResult : ITaskVirtualFolderTimeResult
        where TVirtualFolderPermResult : ITaskVirtualFolderPermResult<TVirtualFolderPermAclResult>
        where TVirtualFolderPermAclResult : ITaskVirtualFolderPermAclResult
        where TVirtualFolderVolumeStatusResult : ITaskVirtualFolderVolumeStatusResult
    {
        /// <summary>
        /// Gets the volume status.
        /// </summary>
        /// <value>The volume status.</value>
        TVirtualFolderVolumeStatusResult VolumeStatus { get; }
    }
}