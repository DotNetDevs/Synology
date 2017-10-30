using Newtonsoft.Json;
using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.CheckPermission.Parameters
{
	public class CheckPermissionWriteParameters : RequestParameters
	{
		[Required]
		public string Path { get; set; }

		[Required]
		[JsonProperty("create_only")]
		public bool CreateOnly { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("create_only", CreateOnly)
			};
		}
	}
}

