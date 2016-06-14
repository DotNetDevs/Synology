using System;
using Synology.Api.Auth;
using System.Runtime.Serialization;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.Api.Auth.Parameters
{
	public class LoginParameters : RequestParameters
	{
		[Required]
		public string Username { get; set; }

		[Required]
		public string Password { get; set; }

		public string OtpCode  { get; set; }

		[Required]
		public string SessionName  { get; set; }

		[Required]
		public AuthFormat Format { get; set; }

		public LoginParameters()
		{
			var rand = new Random((int)DateTime.Now.Ticks);

			OtpCode = null;
			SessionName = $"session{rand.Next()}";
			Format = AuthFormat.Sid;
		}

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("otp_code", OtpCode),
				new QueryStringParameter("account", Username),
				new QueryStringParameter("passwd", Password),
				new QueryStringParameter("session", SessionName),
				new QueryStringParameter("format", Format)
			};
		}
	}
}