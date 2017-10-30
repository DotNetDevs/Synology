using Synology.VideoStation;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionVideoStationExtension
    {
        public static IVideoStationApi VideoStation(this ISynologyConnection connection) => ApiExtension<IVideoStationApi>.Api(connection);
    }
}