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
        public async Task<ResultData<IInfoResult>> GetAsync()
        {
            return ResultData<IInfoResult>.From(await this.GetDataAsync<InfoResult>(new SynologyRequestParameters(this)));
        }
    }
}
