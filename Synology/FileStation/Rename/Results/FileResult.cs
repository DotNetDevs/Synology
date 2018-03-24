using System.Collections.Generic;
using System.Linq;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Rename.Results
{
    /// <summary>
    /// File result.
    /// </summary>
    internal class FileResult : TaskFileResult<FileListResult, FileAdditionalResult, FileOwnerResult, FileTimeResult, FilePermResult, FilePermAclResult, FileResult>, IFileResult
	{
        IEnumerable<IFileListResult> ITaskFileResult<IFileListResult, IFileAdditionalResult, IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult, IFileResult>.Children => Children.Cast<IFileListResult>();

        IFileAdditionalResult ITaskResult<IFileAdditionalResult, IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>.Additional => Additional;
    }
}

