using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// File perm result.
    /// </summary>
    public interface IFilePermResult : ITaskFilePermResult<IFilePermAclResult>
    {
    }
}