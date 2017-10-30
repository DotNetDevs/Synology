using Synology.Api;
using Synology.Api.Info;
using Synology.Extensions;

namespace Synology
{
    public static class ApiInfoExtension
    {
        public static IInfoRequest Info(this IApi api) => RequestExtension<IInfoRequest>.Request(api);
    }
}

