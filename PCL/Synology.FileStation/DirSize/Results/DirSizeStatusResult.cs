using Newtonsoft.Json;

namespace Synology.FileStation.DirSize.Results
{
	public class DirSizeStatusResult
	{
		public bool Finished { get; set; }
		[JsonProperty("num_dir")]
		public int NumDir { get; set; }
		[JsonProperty("num_file")]
		public int NumFile { get; set; }
		[JsonProperty("total_size")]
		public int TotalSize { get; set; }
	}
}

