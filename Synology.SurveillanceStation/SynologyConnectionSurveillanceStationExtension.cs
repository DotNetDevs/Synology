using Synology.SurveillanceStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionSurveillanceStationExtension
    {
        public static SurveillanceStationApi SurveillanceStation(this SynologyConnection connection) => ApiExtension<SurveillanceStationApi>.Api(connection);
    }
}
