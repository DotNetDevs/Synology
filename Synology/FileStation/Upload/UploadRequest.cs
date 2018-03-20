using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Upload.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Upload
{
	[Request("Upload")]
	internal class UploadRequest : FileStationRequest, IUploadRequest
	{
        public UploadRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("upload")]
		public ResultData Upload(UploadParameters parameters)
		{
            return this.PostData(new SynologyPostParameters(this)
			{
				Version = 2,
				Additional = parameters
			});
		}
	}
}
