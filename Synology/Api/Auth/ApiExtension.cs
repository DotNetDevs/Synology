using System;
using Synology;

namespace Synology.Api.Auth
{
	public static class ApiExtension
	{
		private static AuthRequest _auth;

		public static AuthRequest Auth(this Api api)
		{
			return _auth ?? (_auth = api.GetRequest<AuthRequest>());
		}
	}
}

