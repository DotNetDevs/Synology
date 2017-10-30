using System;
using Synology.Classes;
using Synology.DownloadStation.Info.Parameters;
using Synology.DownloadStation.Info.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Info
{
    public interface IInfoRequest : ISynologyRequest
    {
        ResultData<InfoResult> GetInfo();

        ResultData<ConfigResult> Config();

        ResultData SetConfig(SetConfigParameters parameters);
    }
}
