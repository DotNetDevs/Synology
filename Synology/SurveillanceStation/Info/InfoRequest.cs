using Synology.Attributes;
using Synology.Classes;
using Synology.SurveillanceStation.Info.Results;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.SurveillanceStation.Info
{
    /// <inheritdoc cref="SurveillanceStationRequest" />
    /// <summary>
    /// </summary>
    [Request("Info")]
    internal class InfoRequest : SurveillanceStationRequest, IInfoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="api"></param>
        public InfoRequest(ISurveillanceStationApi api) : base(api)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns></returns>
        [RequestMethod("getinfo")]
        public async Task<ResultData<IInfoResult>> GetInfoAsync()
        {
            return ResultData<IInfoResult>.From(await this.GetDataAsync<InfoResult>(new SynologyRequestParameters(this)));
        }
    }
}
