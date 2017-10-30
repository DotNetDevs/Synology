using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.MD5.Results
{
    public class MD5StatusResult : TaskStatusResult
	{
        [JsonProperty("md5")]
		public string MD5 { get; set; }
	}
}

