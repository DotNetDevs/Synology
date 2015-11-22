using System;
using Synology.Classes;

namespace Synology.Auth
{
	public class AuthRequest : SynologyRequest
	{
		readonly string _sessionNumber;

		public AuthRequest(SynologyConnection connection) : base(connection, "auth.cgi", "SYNO.API.Auth", 4)
		{
			var rand = new Random((int)DateTime.Now.Ticks);
			_sessionNumber = string.Format("session{0}", rand.Next());
		}

		public ResultData<LoginResult> Login(string username, string password, string otpCode = null)
		{
			var extraLoginParams = !string.IsNullOrWhiteSpace(otpCode) ? string.Format("&otp_code={0}", otpCode) : string.Empty;
			var additionalParams = string.Format("account={0}&passwd={1}&session={2}&format=sid{3}", username, password, _sessionNumber, extraLoginParams);
			var url = GetApiUrl("login", additionalParams);
			var result = Connection.GetDataFromUrl<LoginResult>(url);

			if (result.Success && result.Data != null && !string.IsNullOrWhiteSpace(result.Data.Sid))
			{
				Connection.Sid = result.Data.Sid;
			}

			return result;
		}

		public ResultData<object> Logout()
		{
			var additionalParams = string.Format("session={0}", _sessionNumber);
			var url = GetApiUrl("logout", additionalParams);
			var result = Connection.GetDataFromUrl<object>(url);

			if (result.Success)
			{
				Connection.Sid = null;
			}

			return result;
		}
	}
}