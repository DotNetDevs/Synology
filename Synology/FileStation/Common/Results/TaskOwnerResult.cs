using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskOwnerResult
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("gid")]
        public int Gid { get; set; }
    }

    public abstract class TaskFileOwnerResult : TaskOwnerResult
    {
    }

    public abstract class TaskShareOwnerResult : TaskOwnerResult
    {
    }

    public abstract class TaskVirtualFolderOwnerResult : TaskOwnerResult
    {
    }
}