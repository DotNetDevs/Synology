using System;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Info.Results;
using Synology.Parameters;

namespace Synology.FileStation.Info
{
	[Request("Info")]
	internal class InfoRequest : FileStationRequest, IInfoRequest
	{
        public InfoRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("get")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<InfoResult> Get()
		{
            return this.GetData<InfoResult>(new SynologyRequestParameters(this));
		}

        [RequestMethod("get")]
        public async Task<ResultData<InfoResult>> GetAsync()
        {
            return await this.GetDataAsync<InfoResult>(new SynologyRequestParameters(this));
        }
	}
}
