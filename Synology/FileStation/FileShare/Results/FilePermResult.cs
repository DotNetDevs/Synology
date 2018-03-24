using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{

    /// <summary>
    /// File perm result.
    /// </summary>
    internal class FilePermResult : TaskFilePermResult<FilePermAclResult>, IFilePermResult
	{
        IFilePermAclResult ITaskPermResult<IFilePermAclResult>.Acl => Acl;
    }
}