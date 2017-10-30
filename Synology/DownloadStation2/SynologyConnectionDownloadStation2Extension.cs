using Synology.DownloadStation2;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class SynologyConnectionDownloadStation2Extension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		/// <returns></returns>
		public static IDownloadStation2Api DownloadStation2(this ISynologyConnection connection) => connection.Api<IDownloadStation2Api>();
	}
}
