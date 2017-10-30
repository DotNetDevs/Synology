﻿using Synology.Attributes;
using System.ComponentModel;

namespace Synology.FileStation.Search.Parameters
{
	public enum FileSortType
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