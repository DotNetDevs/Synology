using System.ComponentModel;

namespace Synology.FileStation.VirtualFolder.Parameters
{
    /// <summary>
    /// Virtual folder type.
    /// </summary>
	public enum VirtualFolderType
	{
        /// <summary>
        /// The cifs.
        /// </summary>
		[Description("cifs")]
		Cifs,
        /// <summary>
        /// The iso.
        /// </summary>
		[Description("iso")]
		Iso
	}
}