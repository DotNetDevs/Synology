using Synology.FileStation;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionFileStationExtension
    {
        public static FileStationApi FileStation(this SynologyConnection connection) => ApiExtension<FileStationApi>.Api(connection);
    }
}