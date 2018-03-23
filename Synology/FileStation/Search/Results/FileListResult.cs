using System.Collections.Generic;
using System.Linq;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// File list result.
    /// </summary>
    internal class FileListResult : TaskFileListResult<FileResult, FileListResult, FileAdditionalResult, FileOwnerResult, FileTimeResult, FilePermResult, FilePermAclResult>, IFileListResult
	{
        IEnumerable<IFileResult> ITaskFileListResult<IFileResult, IFileListResult, IFileAdditionalResult, IFileOwnerResult, IFileTimeResult, IFilePermResult, IFilePermAclResult>.Files => Files.Cast<IFileResult>();
    }
}

