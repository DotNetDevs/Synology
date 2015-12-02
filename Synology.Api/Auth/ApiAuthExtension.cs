using Synology.Api.Auth;
using Synology.Extensions;

namespace Synology
{
	public static class ApiAuthExtension
	{
		public static AuthRequest Auth(this Api.Api api)
		{
			return RequestExtension<AuthRequest>.Request(api);
		}
	}
}