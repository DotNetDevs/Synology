using System.ComponentModel;

namespace Synology.FileStation.VirtualFolder.Parameters
{
	public enum VirtualFolderType
	{
		[Description("cifs")]
		Cifs,
		[Description("iso")]
		Iso
	}
}