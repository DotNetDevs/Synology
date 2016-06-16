using Synology.SurveillanceStation;
using Synology.Extensions;

namespace Synology
{
	public static class SynologyConnectionSurveillanceStationExtension
	{
		public static SurveillanceStationApi SurveillanceStation(this SynologyConnection connection)
		{
			return ApiExtension<SurveillanceStationApi>.Api(connection);
		}
	}
}
