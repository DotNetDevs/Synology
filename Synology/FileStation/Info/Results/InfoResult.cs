using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Info.Results
{
    /// <summary>
    /// Info result.
    /// </summary>
    public class InfoResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.InfoResult"/>
        /// enable list usergrp.
        /// </summary>
        /// <value><c>true</c> if enable list usergrp; otherwise, <c>false</c>.</value>
        [JsonProperty("enable_list_usergrp")]
        public bool EnableListUsergrp { get; set; }

        /// <summary>
        /// Gets or sets the hostname.
        /// </summary>
        /// <value>The hostname.</value>
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.InfoResult"/> is manager.
        /// </summary>
        /// <value><c>true</c> if is manager; otherwise, <c>false</c>.</value>
        [JsonProperty("is_manager")]
        public bool IsManager { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("items")]
        public IEnumerable<InfoItemResult> Items { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.InfoResult"/>
        /// support file request.
        /// </summary>
        /// <value><c>true</c> if support file request; otherwise, <c>false</c>.</value>
        [JsonProperty("support_file_request")]
        public bool SupportFileRequest { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.InfoResult"/>
        /// support sharing.
        /// </summary>
        /// <value><c>true</c> if support sharing; otherwise, <c>false</c>.</value>
        [JsonProperty("support_sharing")]
        public bool SupportSharing { get; set; }

        /// <summary>
        /// Gets or sets the support vfs.
        /// </summary>
        /// <value>The support vfs.</value>
        [JsonProperty("support_vfs")]
        public string SupportVfs { get; set; }

        /// <summary>
        /// Gets or sets the support virtual.
        /// </summary>
        /// <value>The support virtual.</value>
        [JsonProperty("support_virtual")]
        public InfoSupportVirtualResult SupportVirtual { get; set; }

        /// <summary>
        /// Gets or sets the support virtual protocol.
        /// </summary>
        /// <value>The support virtual protocol.</value>
        [JsonProperty("support_virtual_protocol")]
        public string SupportVirtualProtocol { get; set; }

        /// <summary>
        /// Gets or sets the system codepage.
        /// </summary>
        /// <value>The system codepage.</value>
        [JsonProperty("system_codepage")]
        public string SystemCodepage { get; set; }

        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        /// <value>The uid.</value>
        [JsonProperty("uid")]
        public int Uid { get; set; }
    }

    /// <summary>
    /// Info item result.
    /// </summary>
    public class InfoItemResult
    {
        /// <summary>
        /// Gets or sets the gid.
        /// </summary>
        /// <value>The gid.</value>
        [JsonProperty("gid")]
        public int Gid { get; set; }
    }

    /// <summary>
    /// Info support virtual result.
    /// </summary>
    public class InfoSupportVirtualResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Info.Results.InfoSupportVirtualResult"/> enable iso mount.
        /// </summary>
        /// <value><c>true</c> if enable iso mount; otherwise, <c>false</c>.</value>
        [JsonProperty("enable_iso_mount")]
        public bool EnableIsoMount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Info.Results.InfoSupportVirtualResult"/> enable remote mount.
        /// </summary>
        /// <value><c>true</c> if enable remote mount; otherwise, <c>false</c>.</value>
        [JsonProperty("enable_remote_mount")]
        public bool EnableRemoteMount { get; set; }
    }
}

