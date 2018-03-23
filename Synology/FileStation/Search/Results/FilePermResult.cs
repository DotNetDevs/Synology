using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// File perm result.
    /// </summary>
    internal class FilePermResult : TaskFilePermResult<FilePermAclResult>, IFilePermResult
	{
		IFilePermAclResult ITaskPermResult<IFilePermAclResult>.Acl => Acl;
    }
}