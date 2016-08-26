﻿using Synology.Api.Info;
using Synology.Extensions;

namespace Synology
{
    public static class ApiInfoExtension
    {
        public static InfoRequest Info(this Api.Api api) => RequestExtension<InfoRequest>.Request(api);
    }
}

