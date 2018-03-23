using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Rename.Results
{
    /// <summary>
    /// File perm result.
    /// </summary>
    public interface IFilePermResult : ITaskFilePermResult<IFilePermAclResult>
    {
    }
}