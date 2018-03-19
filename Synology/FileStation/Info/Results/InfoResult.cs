using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Info.Results
{
    public class InfoResult
    {
        [JsonProperty("enable_list_usergrp")]
        public bool EnableListUsergrp { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("is_manager")]
        public bool IsManager { get; set; }

        [JsonProperty("items")]
        public IEnumerable<InfoItemResult> Items { get; set; }

        [JsonProperty("support_file_request")]
        public bool SupportFileRequest { get; set; }

        [JsonProperty("support_sharing")]
        public bool SupportSharing { get; set; }

        [JsonProperty("support_vfs")]
        public string SupportVfs { get; set; }

        [JsonProperty("support_virtual")]
        public InfoSupportVirtualResult SupportVirtual { get; set; }

        [JsonProperty("support_virtual_protocol")]
        public string SupportVirtualProtocol { get; set; }

        [JsonProperty("system_codepage")]
        public string SystemCodepage { get; set; }

        [JsonProperty("uid")]
        public int Uid { get; set; }
    }

    public class InfoItemResult
    {
        [JsonProperty("gid")]
        public int Gid { get; set; }
    }

    public class InfoSupportVirtualResult
    {
        [JsonProperty("enable_iso_mount")]
        public bool EnableIsoMount { get; set; }

        [JsonProperty("enable_remote_mount")]
        public bool EnableRemoteMount { get; set; }
    }
}

