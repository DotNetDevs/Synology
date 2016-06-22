using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    public class ShareAclResult
    {
        /// <summary>
        /// If a logged-in user has a privilege to append data or create folders within this folder or not.
        /// </summary>
        [JsonProperty("append")]
        public bool Append { get; set; }

        /// <summary>
        /// If a logged-in user has a privilege to delete a file/a folder within this folder or not.
        /// </summary>
        [JsonProperty("del")]
        public bool Delete { get; set; }

        /// <summary>
        /// If a logged-in user has a privilege to execute files/traverse folders within this folder or not
        /// </summary>
        [JsonProperty("exec")]
        public bool Execute { get; set; }

        /// <summary>
        /// If a logged-in user has a privilege to read data or list folder within this folder or not.
        /// </summary>
        [JsonProperty("read")]
        public bool Read { get; set; }

        /// <summary>
        /// If a logged-in user has a privilege to write data or create files within this folder or not.
        /// </summary>
        [JsonProperty("write")]
        public bool Write { get; set; }
    }
}