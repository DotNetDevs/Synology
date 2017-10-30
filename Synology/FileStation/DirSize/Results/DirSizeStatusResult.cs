using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.DirSize.Results
{
    public class DirSizeStatusResult : TaskStatusResult
	{
		[JsonProperty("num_dir")]
		public int NumDir { get; set; }
		[JsonProperty("num_file")]
		public int NumFile { get; set; }
		[JsonProperty("total_size")]
		public int TotalSize { get; set; }
	}
}

