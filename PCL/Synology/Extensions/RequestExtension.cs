using System;
using Synology.Classes;

namespace Synology.Extensions
{
    public static class RequestExtension<T> where T : SynologyRequest
    {
        public static T Request(SynologyApi api) => api.Request<T>();
    }
}

