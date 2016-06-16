using Synology.SurveillanceStation;
using Synology.SurveillanceStation.Info;
using Synology.Extensions;

namespace Synology
{
	public static class SurveillanceStationInfoExtension
	{
		public static SurveillanceStationRequest Info(this SurveillanceStationApi api)
		{
			return RequestExtension<InfoRequest>.Request(api);
		}
	}
}

