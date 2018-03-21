using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.Thumb.Parameters;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.Thumb
{
	[Request("Thumb")]
	internal class ThumbRequest : FileStationRequest, IThumbRequest
	{
        public ThumbRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("get")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<byte[]> Get(ThumbGetParameters parameters)
		{
            return this.GetData<byte[]>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

        [RequestMethod("get")]
        public async Task<ResultData<byte[]>> GetAsync(ThumbGetParameters parameters)
        {
            return await this.GetDataAsync<byte[]>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
	}
}