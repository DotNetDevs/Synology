using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Synology.Parameters;

namespace Synology.FileStation.MD5.Parameters
{
	public class MD5StartParameters : RequestParameters
	{
		[Required]
		[JsonProperty("file_path")]
		public string FilePath { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("file_path", FilePath)
			};
		}
	}
}

