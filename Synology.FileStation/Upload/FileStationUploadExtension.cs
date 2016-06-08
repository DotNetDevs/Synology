using Synology.Extensions;
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
        public static UploadRequest Upload(this FileStationApi api)
        {
            return RequestExtension<UploadRequest>.Request(api);
        }
    }
}
