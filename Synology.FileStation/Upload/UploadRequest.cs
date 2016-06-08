using Synology.Classes;
using Synology.FileStation.Upload.Parameters;

namespace Synology.FileStation.Upload
{
    public class UploadRequest : FileStationRequest
    {
        public UploadRequest(SynologyApi api) : base(api, "Upload")
        {
        }

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
