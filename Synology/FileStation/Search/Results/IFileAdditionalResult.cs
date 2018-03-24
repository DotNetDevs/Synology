using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// File additional result.
    /// </summary>
    public interface IFileAdditionalResult : ITaskFileAdditionalResult<IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>
    {
    }
}