using System;
using Synology.Classes;
using Synology.Utilities;

namespace Synology.Api.Auth
{
	public class AuthRequest : SynologyRequest
	{
		private string _sessionNumber;

		public AuthRequest(SynologyConnection connection) : base(connection, "auth.cgi", "SYNO.API.Auth")
		{
		}

		public ResultData<AuthResult> Login(LoginParameters parameters)
		{
			_sessionNumber = parameters.SessionName;

			var result = GetData<AuthResult>(new SynologyRequestParameters
			{
				Method = "login",
				Version = 4,
				Additional = parameters
			});

			if (result.Success && !string.IsNullOrWhiteSpace(result.Data?.Sid))
				Connection.Sid = result.Data.Sid;

			return result;
		}

		public ResultData Logout()
		{
			var parameters = new[] {
				new QueryStringParameter("session", _sessionNumber),
			};

			var result = GetData(new SynologyRequestParameters
			{
				Method = "logout",
				Additional = parameters
			});

			if (result.Success)
				Connection.Sid = null;

			return result;
		}
	}
}