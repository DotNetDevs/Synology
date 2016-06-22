using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    public class ShareSpecialPrivilegeResult
    {
        /// <summary>
        /// If a non-administrator user can download files in this shared folder through SYNO.FileStation.Download API or not.
        /// </summary>
        [JsonProperty("disable_download")]
        public bool DisableDownload { get; set; }

        /// <summary>
        /// If a non-administrator user can enumerate files in this shared folder though SYNO.FileStation. List API with list method or not.
        /// </summary>
        [JsonProperty("disable_list")]
        public bool DisableList { get; set; }

        /// <summary>
        /// If a non-administrator user can modify or overwrite files in this shared folder or not.
        /// </summary>
        [JsonProperty("disable_modify")]
        public bool DisableModify { get; set; }
    }
}
