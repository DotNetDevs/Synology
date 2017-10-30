using Synology.SurveillanceStation;
using Synology.SurveillanceStation.Info;
using Synology.Extensions;

namespace Synology
{
	public static class SurveillanceStationInfoExtension
	{
		public static IInfoRequest Info(this ISurveillanceStationApi api)
		{
			return RequestExtension<IInfoRequest>.Request(api);
		}
	}
}

