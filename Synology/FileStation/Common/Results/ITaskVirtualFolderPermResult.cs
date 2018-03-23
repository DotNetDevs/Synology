namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task virtual folder perm result.
    /// </summary>
    public interface ITaskVirtualFolderPermResult<TVirtualFolderPermAclResult> : ITaskPermResult<TVirtualFolderPermAclResult> where TVirtualFolderPermAclResult : ITaskVirtualFolderPermAclResult
    {
    }
}