using System.Collections.Generic;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task virtual folder list result.
    /// </summary>
    public interface ITaskVirtualFolderListResult<TVirtualFolderResult, TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>
        where TVirtualFolderResult : ITaskVirtualFolderResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>
        where TVirtualFolderAdditionalResult : ITaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>
        where TVirtualFolderOwnerResult : ITaskVirtualFolderOwnerResult
        where TVirtualFolderTimeResult : ITaskVirtualFolderTimeResult
        where TVirtualFolderPermResult : ITaskVirtualFolderPermResult<TVirtualFolderPermAclResult>
        where TVirtualFolderPermAclResult : ITaskVirtualFolderPermAclResult
        where TVirtualFolderVolumeStatusResult : ITaskVirtualFolderVolumeStatusResult
    {
        /// <summary>
        /// Gets the folders.
        /// </summary>
        /// <value>The folders.</value>
        IEnumerable<TVirtualFolderResult> Folders { get; }
    }
}