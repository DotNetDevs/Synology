using Synology.Attributes;
using System.ComponentModel;

namespace Synology.FileStation.VirtualFolder.Parameters
{
	public enum VirtualFolderSortType
	{
		[Description("name")]
		Name,
		[Description("user")]
		User,
		[Description("group")]
		Group,
		[Description("mtime")]
		LastModifiedTime,
		[Description("atime")]
		LastAccessTime,
		[Description("ctime")]
		LastChangeTime,
		[Description("crtime")]
		CreateTime,
		[Description("posix")]
		Posix
	}
}