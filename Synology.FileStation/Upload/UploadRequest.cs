using Synology.Classes;
using Synology.FileStation.Upload.Parameters;

namespace Synology.FileStation.Upload
{
    public class UploadRequest : SynologyRequest
    {
        public UploadRequest(SynologyApi api) : base(api, "entry.cgi", "FileStation.Upload")
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
