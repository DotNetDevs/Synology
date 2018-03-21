using System;
using System.Threading.Tasks;
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
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData Upload(UploadParameters parameters)
		{
            return this.PostData(new SynologyPostParameters(this)
			{
				Version = 2,
				Additional = parameters
			});
		}

        [RequestMethod("upload")]
        public async Task<ResultData> UploadAsync(UploadParameters parameters)
        {
            return await this.PostDataAsync(new SynologyPostParameters(this)
            {
                Version = 2,
                Additional = parameters
            });
        }
	}
}
