using Synology.Extensions;
using Synology.FileStation;
using Synology.FileStation.Rename;

namespace Synology
{
    public static class FileStationRenameExtension
    {
        public static RenameRequest Rename(this FileStationApi api)
        {
            return RequestExtension<RenameRequest>.Request(api);
        }
    }
}
