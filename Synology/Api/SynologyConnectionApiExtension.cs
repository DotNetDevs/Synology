using Synology.Api;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
    public static class SynologyConnectionApiExtension
    {
        public static IApi Api(this ISynologyConnection connection) => ApiExtension<IApi>.Api(connection);
    }
}