using System;
using System.ComponentModel;

namespace Synology.FileStation.VirtualFolder
{
	public enum VirtualFolderType
	{
		[Description("cifs")]
		Cifs,
		[Description("iso")]
		Iso
	}
}