using Synology.Extensions;
using Synology.FileStation;
using Synology.FileStation.Rename;

namespace Synology
{
    public static class FileStationRenameExtension
    {
        public static IRenameRequest Rename(this IFileStationApi api)
        {
            return RequestExtension<IRenameRequest>.Request(api);
        }
    }
}
