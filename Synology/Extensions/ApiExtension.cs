using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Extensions
{
    public static class ApiExtension<T> where T : ISynologyApi
    {
        public static T Api(ISynologyConnection connection) => connection.Api<T>();
    }
}

