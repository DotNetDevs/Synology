using System;
using Synology;
using Synology.Api.Auth;

namespace Synology.Api
{
	public static class ApiAuthExtension
	{
		private static AuthRequest _auth;

		public static AuthRequest Auth(this Api api)
		{
			return _auth ?? (_auth = api.GetRequest<AuthRequest>());
		}
	}
}

