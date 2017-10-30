using Synology.Classes;
using Synology.FileStation.MD5.Parameters;
using Synology.FileStation.MD5.Results;
using Synology.Interfaces;

namespace Synology.FileStation.MD5
{
    public interface IMD5Request : ISynologyRequest
    {
        ResultData<MD5StartResult> Start(MD5StartParameters parameters);

        ResultData<MD5StatusResult> Status(MD5StatusParameters parameters);

        ResultData Stop(MD5StatusParameters parameters);
    }
}