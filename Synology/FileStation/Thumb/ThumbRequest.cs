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
        public async Task<ResultData<byte[]>> GetAsync(ThumbGetParameters parameters)
        {
            return await this.GetDataAsync<byte[]>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
	}
}