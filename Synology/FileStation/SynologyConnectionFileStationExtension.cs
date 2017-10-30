using Synology.FileStation;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionFileStationExtension
    {
        public static IFileStationApi FileStation(this ISynologyConnection connection) => connection.Api<IFileStationApi>();
    }
}