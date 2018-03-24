using Synology.SurveillanceStation;
using Synology;
using Synology.Interfaces;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class SynologyConnectionSurveillanceStationExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		/// <returns></returns>
		public static ISurveillanceStationApi SurveillanceStation(this ISynologyConnection connection) => connection.Api<ISurveillanceStationApi>();
	}
}
