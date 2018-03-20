using Synology;
using Synology.FileStation;
using Synology.FileStation.Upload;

namespace Synology
{
    public static class FileStationUploadExtension
    {
        /// <summary>
        /// The File Station Upload API
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public static IUploadRequest Upload(this IFileStationApi api)
        {
            return api.Request<IUploadRequest>();
        }
    }
}
