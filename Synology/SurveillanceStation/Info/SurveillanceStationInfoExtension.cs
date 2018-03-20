using Synology.SurveillanceStation;
using Synology.SurveillanceStation.Info;
using Synology;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class SurveillanceStationInfoExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="api"></param>
		/// <returns></returns>
		public static IInfoRequest Info(this ISurveillanceStationApi api)
		{
			return api.Request<IInfoRequest>();
		}
	}
}

