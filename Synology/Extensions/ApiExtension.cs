using Synology.Classes;

namespace Synology.Extensions
{
    public static class ApiExtension<T> where T : SynologyApi
    {
        public static T Api(SynologyConnection connection) => connection.Api<T>();
    }
}

