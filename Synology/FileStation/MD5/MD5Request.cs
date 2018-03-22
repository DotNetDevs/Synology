using System;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.MD5.Parameters;
using Synology.FileStation.MD5.Results;
using Synology.Parameters;

namespace Synology.FileStation.MD5
{
    [Request("MD5")]
    internal class MD5Request : FileStationRequest, IMD5Request
    {
        public MD5Request(IFileStationApi api) : base(api)
        {
        }

        [RequestMethod("start")]
        public async Task<ResultData<MD5StartResult>> StartAsync(MD5StartParameters parameters)
        {
            return await this.GetDataAsync<MD5StartResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }

        [RequestMethod("status")]
        public async Task<ResultData<IMD5StatusResult>> StatusAsync(MD5StatusParameters parameters)
        {
            return ResultData<IMD5StatusResult>.From(await this.GetDataAsync<MD5StatusResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            }));
        }

        [RequestMethod("stop")]
        public async Task<ResultData> StopAsync(MD5StatusParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
    }
}