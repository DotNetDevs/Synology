using System;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Synology.Api.Auth
{
	public enum AuthFormat
	{
		[Description("cookie")]
		Cookie,
		[Description("sid")]
		Sid
	}
}

