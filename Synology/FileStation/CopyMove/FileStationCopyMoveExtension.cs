using Synology;
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
        public static ICopyMoveRequest CopyMove(this IFileStationApi api)
        {
            return api.Request<ICopyMoveRequest>();
        }
    }
}