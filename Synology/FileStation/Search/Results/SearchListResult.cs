using System.Collections.Generic;
using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    public class SearchListResult : TaskStatusResult
	{
        [JsonProperty("total")]
		public int Total { get; set; }

        [JsonProperty("offset")]
		public int Offset { get; set; }

        [JsonProperty("files")]
		public IEnumerable<FileResult> Files { get; set; }
	}
}

