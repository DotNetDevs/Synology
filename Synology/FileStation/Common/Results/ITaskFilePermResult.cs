namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task file perm result.
    /// </summary>
    public interface ITaskFilePermResult<TFilePermAclResult> : ITaskPermResult<TFilePermAclResult>
        where TFilePermAclResult : ITaskFilePermAclResult
    {
    }
}