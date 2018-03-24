using Synology.Attributes;
using Synology.Classes;
using Synology.DownloadStation.Info.Results;
using Synology.DownloadStation.Info.Parameters;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.DownloadStation.Info
{
    [Request("Info")]
    internal class InfoRequest : DownloadStationRequest, IInfoRequest
    {
        public InfoRequest(IDownloadStationApi api) : base(api)
        {
        }

        [RequestMethod("getinfo")]
        public async Task<ResultData<IInfoResult>> GetInfoAsync()
        {
            var res = await this.GetDataAsync<InfoResult>(new SynologyRequestParameters(this));

            return ResultData<IInfoResult>.From(res);
        }

        [RequestMethod("getconfig")]
        public async Task<ResultData<IConfigResult>> ConfigAsync()
        {
            var res = await this.GetDataAsync<ConfigResult>(new SynologyRequestParameters(this) { Version = 2 });

            return ResultData<IConfigResult>.From(res);
        }

        [RequestMethod("setserverconfig")]
        public async Task<ResultData> SetConfigAsync(SetConfigParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters
            });
        }
    }
}