using System;
using Synology.Classes;

namespace Synology.Auth
{
	public class AuthRequest : SynologyRequest
	{
		private readonly Random _rand;

		public AuthRequest(SynologyConnection connection) : base(connection, "auth.cgi", "SYNO.API.Auth", 4)
		{
			_rand = new Random((int)DateTime.Now.Ticks);
		}

		public ResultData<AuthResult> Login(string username, string password, string otpCode = null)
		{
			var extraLoginParams = !string.IsNullOrWhiteSpace(otpCode) ? string.Format("&otp_code={0}", otpCode) : string.Empty;
			var additionalParams = string.Format("account={0}&passwd={1}&session=session{2}&format=sid{3}", username, password, _rand.Next() % 1000, extraLoginParams);
			var url = GetApiUrl("login", additionalParams);

			return Connection.GetDataFromUrl<AuthResult>(url);
		}
	}
}