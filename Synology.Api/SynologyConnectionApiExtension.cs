using Synology.Extensions;

namespace Synology
{
    public static class SynologyConnectionApiExtension
    {
        public static Api.Api Api(this SynologyConnection connection) => ApiExtension<Api.Api>.Api(connection);
    }
}