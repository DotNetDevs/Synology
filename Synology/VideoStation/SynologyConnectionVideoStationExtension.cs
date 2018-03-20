using Synology.VideoStation;
using Synology;
using Synology.Interfaces;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class SynologyConnectionVideoStationExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		/// <returns></returns>
		public static IVideoStationApi VideoStation(this ISynologyConnection connection) => connection.Api<IVideoStationApi>();
	}
}