using Synology.Api;
using Synology.Api.Auth;
using Synology.Extensions;

namespace Synology
{
	public static class ApiAuthExtension
	{
		public static IAuthRequest Auth(this IApi api)
		{
			return RequestExtension<IAuthRequest>.Request(api);
		}
	}
}