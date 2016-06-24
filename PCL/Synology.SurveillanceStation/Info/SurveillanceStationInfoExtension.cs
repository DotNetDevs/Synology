using Synology.SurveillanceStation;
using Synology.SurveillanceStation.Info;
using Synology.Extensions;

namespace Synology
{
	public static class SurveillanceStationInfoExtension
	{
		public static InfoRequest Info(this SurveillanceStationApi api)
		{
			return RequestExtension<InfoRequest>.Request(api);
		}
	}
}

