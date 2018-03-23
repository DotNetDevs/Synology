using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// File result.
    /// </summary>
    public interface IFileResult : ITaskFileResult<IFileListResult, IFileAdditionalResult, IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult, IFileResult>
    {
    }
}