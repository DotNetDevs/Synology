using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskPermAclResult
	{
        [JsonProperty("append")]
		public bool Append { get; set; }

        [JsonProperty("del")]
		public bool Delete { get; set; }

        [JsonProperty("exec")]
		public bool Execute { get; set; }

        [JsonProperty("read")]
		public bool Read { get; set; }

        [JsonProperty("write")]
		public bool Write { get; set; }
	}

    public abstract class TaskFilePermAclResult : TaskPermAclResult
    {
    }

    public abstract class TaskSharePermAclResult : TaskPermAclResult
    {
    }

    public abstract class TaskVirtualFolderPermAclResult : TaskPermAclResult
    {
    }
}