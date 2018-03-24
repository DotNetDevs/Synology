using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// File additional result.
    /// </summary>
    internal class FileAdditionalResult : TaskFileAdditionalResult<FileOwnerResult, FileTimeResult, FilePermResult, FilePermAclResult>, IFileAdditionalResult
	{
        IFileOwnerResult ITaskAdditionalResult<IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>.Owner => Owner;

        IFileTimeResult ITaskAdditionalResult<IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>.Time => Time;

        IFilePermResult ITaskAdditionalResult<IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>.Perm => Perm;
    }
}

