using System.ComponentModel;

namespace Synology.FileStation.Search
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