using Synology.Attributes;
using System.ComponentModel;

namespace Synology.FileStation.Search.Parameters
{
	public enum FileType
	{
		[Description("file")]
		File,
		[Description("dir")]
		Directory,
		[Description("all")]
		All
	}
}