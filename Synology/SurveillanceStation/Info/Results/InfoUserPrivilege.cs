namespace Synology.SurveillanceStation.Info.Results
{
	using System;

	/// <summary>
	/// 
	/// </summary>
	[Flags]
	public enum InfoUserPrivilege
	{
		/// <summary>
		/// 
		/// </summary>
		NoAccess = 0x00,
		/// <summary>
		/// 
		/// </summary>
		Admin = 0x01,
		/// <summary>
		/// 
		/// </summary>
		Manager = 0x02,
		/// <summary>
		/// 
		/// </summary>
		Viewer = 0x04,
		/// <summary>
		/// 
		/// </summary>
		All = 0xFF
	}
}