using Synology.Extensions;
using Synology.FileStation;
using Synology.FileStation.CopyMove;

namespace Synology
{
    public static class FileStationCopyMoveExtension
    {
        /// <summary>
        /// Copy or Move API operations
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public static CopyMoveRequest CopyMove(this FileStationApi api)
        {
            return RequestExtension<CopyMoveRequest>.Request(api);
        }
    }
}