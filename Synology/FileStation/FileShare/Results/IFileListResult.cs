using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// File list result.
    /// </summary>
    public interface IFileListResult : ITaskFileListResult<IFileResult, IFileListResult, IFileAdditionalResult, IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>
    {
    }
}