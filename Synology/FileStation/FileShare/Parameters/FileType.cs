using System.ComponentModel;

namespace Synology.FileStation.FileShare.Parameters
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