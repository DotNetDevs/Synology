using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Upload.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Upload
{
    public class UploadRequest : FileStationRequest
    {
        public UploadRequest(SynologyApi api) : base(api, "Upload")
        {
        }

        [RequestMethod("upload")]
        public ResultData Upload(UploadParameters parameters)
        {
            return PostData(new SynologyPostParameters
            {
                Version = 2,
                Method = "upload",
                Additional = parameters
            });
        }
    }
}
