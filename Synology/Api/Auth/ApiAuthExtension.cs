using Synology.Api.Auth;

namespace Synology
{
	public static class ApiAuthExtension
	{
		private static AuthRequest _auth;

		public static AuthRequest Auth(this Api.Api api)
		{
			return _auth ?? (_auth = api.GetRequest<AuthRequest>());
		}
	}
}

