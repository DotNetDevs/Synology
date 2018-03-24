using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// File result.
    /// </summary>
    public interface IFileResult : ITaskFileResult<IFileListResult, IFileAdditionalResult, IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult, IFileResult>
    {
    }
}