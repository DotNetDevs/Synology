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
			var rand = new Random((int)DateTime.Now.Ticks);
			_sessionNumber = $"session{rand.Next()}";
		}

		public ResultData<AuthResult> Login(string username, string password, string otpCode = null, string sessionName = null, AuthFormat format = AuthFormat.Sid)
		{
			_sessionNumber = sessionName ?? _sessionNumber;

			var parameters = new[] {
				new QueryStringParameter("otp_code", otpCode),
				new QueryStringParameter("account", username),
				new QueryStringParameter("passwd", password),
				new QueryStringParameter("session", _sessionNumber),
				new QueryStringParameter("format", format)
			};

			var result = GetData<AuthResult>("login", 4, parameters);

			if (result.Success && !string.IsNullOrWhiteSpace(result.Data?.Sid))
			{
				Connection.Sid = result.Data.Sid;
			}

			return result;
		}

		public ResultData Logout()
		{
			var parameters = new[] {
				new QueryStringParameter("session", _sessionNumber),
			};

			var result = GetData("logout", 1, parameters);

			if (result.Success)
			{
				Connection.Sid = null;
			}

			return result;
		}
	}
}