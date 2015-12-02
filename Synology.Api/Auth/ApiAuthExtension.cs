using Synology.Api.Auth;

namespace Synology
{
	public static class ApiAuthExtension
	{
		private static AuthRequest _auth;

		public static AuthRequest Auth(this Api.Api api)
		{
			if (_auth == null)
			{
				api.RegisterRequest<AuthRequest>();
				_auth = api.GetRequest<AuthRequest>();
			}

			return _auth;
		}
	}
}

