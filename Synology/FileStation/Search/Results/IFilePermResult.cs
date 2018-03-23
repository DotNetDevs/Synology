using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// File perm result.
    /// </summary>
    public interface IFilePermResult : ITaskFilePermResult<IFilePermAclResult>
    {
    }
}