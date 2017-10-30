using Synology.Interfaces;

namespace Synology.Extensions
{
    public static class RequestExtension<T> where T : class, ISynologyRequest
    {
        public static T Request(ISynologyApi api) => api.Request<T>();
    }
}

