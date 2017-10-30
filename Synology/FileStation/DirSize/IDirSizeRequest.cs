using Synology.Classes;
using Synology.FileStation.DirSize.Parameters;
using Synology.FileStation.DirSize.Results;
using Synology.Interfaces;

namespace Synology.FileStation.DirSize
{
    public interface IDirSizeRequest : ISynologyRequest
    {
        ResultData<DirSizeStartResult> Start(DirSizeStartParameters parameters);

        ResultData<DirSizeStatusResult> Status(DirSizeStatusParameters parameters);

        ResultData Stop(DirSizeStatusParameters parameters);
    }
}