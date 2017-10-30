using Newtonsoft.Json;

namespace Synology.SurveillanceStation.Info.Results
{
    public class InfoResult
    {
        [JsonProperty("version")]
        public InfoVersion Version { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("customizedPortHttp")]
        public int? CustomizedPortHttp { get; set; }

        [JsonProperty("customizedPortHttps")]
        public int? CustomizedPortHttps { get; set; }

        [JsonProperty("cameraNumber")]
        public int CameraNumber { get; set; }

        [JsonProperty("licenseNumber")]
        public int LicenseNumber { get; set; }

        [JsonProperty("maxCameraSupport")]
        public int MaxCameraSupport { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("userPriv")]
        public InfoUserPrivilege UserPrivilege { get; set; }

        [JsonProperty("isLicenseEnough")]
        public bool IsLicenseEnough { get; set; }

        [JsonProperty("allowSnapshot")]
        public bool AllowSnapshot { get; set; }

        [JsonProperty("allowManualRec")]
        public bool AllowManualRecording { get; set; }

        [JsonProperty("allowDeleteRec")]
        public bool AllowDeleteRecording { get; set; }
    }
}

