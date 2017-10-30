using System;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;
using System.ComponentModel;
using Synology.Attributes;
using Newtonsoft.Json;

namespace Synology.Api.Auth.Parameters
{
	public class LoginParameters : RequestParameters
	{
		[Required]
		[Description("account")]
        [JsonProperty("account")]
		[MinVersion(1)]
		public string Username { get; set; }

		[Required]
		[Description("passwd")]
        [JsonProperty("passwd")]
		[MinVersion(1)]
		public string Password { get; set; }

		[Description("otp_code")]
        [JsonProperty("otp_code")]
		public string OtpCode  { get; set; }

		[Required]
		[Description("session")]
        [JsonProperty("session")]
		public string SessionName  { get; set; }

		[Required]
		[Description("format")]
        [JsonProperty("format")]
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