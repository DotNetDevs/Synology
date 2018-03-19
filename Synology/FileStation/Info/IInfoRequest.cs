using Synology.Classes;
using Synology.FileStation.Info.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Info
{
    public interface IInfoRequest : ISynologyRequest
    {
        ResultData<InfoResult> Get();
    }
}
