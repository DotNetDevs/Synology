using Synology.SurveillanceStation;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionSurveillanceStationExtension
    {
        public static ISurveillanceStationApi SurveillanceStation(this ISynologyConnection connection) => connection.Api<ISurveillanceStationApi>();
    }
}
