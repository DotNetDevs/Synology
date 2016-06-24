using System;
using Newtonsoft.Json;
using System.ComponentModel;
using Synology.Attributes;

namespace Synology.Api.Auth.Parameters
{
	public enum AuthFormat
	{
		[Description("cookie")]
		Cookie,
		[Description("sid")]
		Sid
	}
}

