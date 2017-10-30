using Synology.Classes;
using Synology.Interfaces;
using Synology.SurveillanceStation.Info.Results;

namespace Synology.SurveillanceStation.Info
{
    public interface IInfoRequest : ISynologyRequest
    {
        ResultData<InfoResult> GetInfo();
    }
}
