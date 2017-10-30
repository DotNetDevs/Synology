using System.ComponentModel;

namespace Synology.Api.Auth.Parameters
{
	/// <summary>
	/// 
	/// </summary>
	public enum AuthFormat
	{
		/// <summary>
		/// 
		/// </summary>
		[Description("cookie")]
		Cookie,
		/// <summary>
		/// 
		/// </summary>
		[Description("sid")]
		Sid
	}
}

