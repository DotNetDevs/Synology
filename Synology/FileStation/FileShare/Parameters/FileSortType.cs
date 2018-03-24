using System.ComponentModel;

namespace Synology.FileStation.FileShare.Parameters
{
    /// <summary>
    /// File sort type.
    /// </summary>
	public enum FileSortType
	{
        /// <summary>
        /// The name.
        /// </summary>
		[Description("name")]
		Name,

        /// <summary>
        /// The user.
        /// </summary>
		[Description("user")]
		User,

        /// <summary>
        /// The group.
        /// </summary>
		[Description("group")]
		Group,

        /// <summary>
        /// The last modified time.
        /// </summary>
		[Description("mtime")]
		LastModifiedTime,

        /// <summary>
        /// The last access time.
        /// </summary>
		[Description("atime")]
		LastAccessTime,

        /// <summary>
        /// The last change time.
        /// </summary>
		[Description("ctime")]
		LastChangeTime,

        /// <summary>
        /// The create time.
        /// </summary>
		[Description("crtime")]
		CreateTime,

        /// <summary>
        /// The posix.
        /// </summary>
		[Description("posix")]
		Posix
	}
}