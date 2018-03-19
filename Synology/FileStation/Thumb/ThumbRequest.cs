using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.Thumb.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Thumb
{
	[Request("Thumb")]
	internal class ThumbRequest : FileStationRequest, IThumbRequest
	{
        public ThumbRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("get")]
		public ResultData<byte[]> Get(ThumbGetParameters parameters)
		{
			return GetData<byte[]>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}