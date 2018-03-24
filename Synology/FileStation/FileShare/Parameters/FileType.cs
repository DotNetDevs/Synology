using System.ComponentModel;

namespace Synology.FileStation.FileShare.Parameters
{
    /// <summary>
    /// File type.
    /// </summary>
	public enum FileType
	{
        /// <summary>
        /// The file.
        /// </summary>
		[Description("file")]
		File,

        /// <summary>
        /// The directory.
        /// </summary>
		[Description("dir")]
		Directory,

        /// <summary>
        /// All.
        /// </summary>
		[Description("all")]
		All
	}
}