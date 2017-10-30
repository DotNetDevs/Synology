using System;
using System.Collections.Generic;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api.Info
{
    public interface IInfoRequest : ISynologyRequest
    {
        ResultData<Dictionary<string, IApiInfo>> Query(params string[] apis);
    }
}
