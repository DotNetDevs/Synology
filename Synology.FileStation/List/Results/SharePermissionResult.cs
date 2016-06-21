using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    public class SharePermissionResult
    {
        /// <summary>
        /// "RW": The shared folder is writable; "RO": the shared folder is read-only.
        /// </summary>
        [JsonProperty("share_right")]
        public string ShareRight { get; set; }

        /// <summary>
        /// POSIX file permission, For example, 777 means owner, group or other has all permission; 764 means owner has all permission, group has read/write permission, other has read permission.
        /// </summary>
        [JsonProperty("posix")]
        public string Posix { get; set; }

        /// <summary>
        /// Special privelge of the shared folder
        /// </summary>
        [JsonProperty("adv_right")]
        public ShareSpecialPrivilegeResult AdvancedRight { get; set; }

        /// <summary>
        /// If the configure of Windows ACL privilege of the shared folder is enabled or not.
        /// </summary>
        [JsonProperty("acl_enable")]
        public bool AclEnabled { get; set; }

        /// <summary>
        /// "true": The privilege of the shared folder is set to be ACL-mode. "false": The privilege of the shared folder is set to be POSIX-mode.
        /// </summary>
        [JsonProperty("is_acl_mode")]
        public bool IsAclMode { get; set; }

        /// <summary>
        /// Windows ACL privilege. If a shared folder is set to be POSIX-mode, these values of Windows ACL privileges are derived from the POSIX privilege.
        /// </summary>
        [JsonProperty("acl")]
        public ShareAclResult Acl { get; set; }
    }
}
