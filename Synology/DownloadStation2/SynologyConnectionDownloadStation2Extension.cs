using Synology.DownloadStation2;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionDownloadStation2Extension
    {
        public static IDownloadStation2Api DownloadStation2(this ISynologyConnection connection) => ApiExtension<IDownloadStation2Api>.Api(connection);
    }
}
