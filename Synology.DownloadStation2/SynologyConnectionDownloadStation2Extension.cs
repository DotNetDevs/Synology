using Synology.DownloadStation2;
using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionDownloadStation2Extension
    {
        public static DownloadStation2Api DownloadStation2(this SynologyConnection connection) => ApiExtension<DownloadStation2Api>.Api(connection);
    }
}
