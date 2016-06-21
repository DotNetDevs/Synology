using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Upload.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Upload
{
    [Request("Upload")]
    public class UploadRequest : FileStationRequest
    {
        public UploadRequest(SynologyApi api) : base(api)
        {
        }

        [RequestMethod("upload")]
        public ResultData Upload(UploadParameters parameters)
        {
            return PostData(new SynologyPostParameters
            {
                Version = 2,
                Additional = parameters
            });
        }
    }
}
