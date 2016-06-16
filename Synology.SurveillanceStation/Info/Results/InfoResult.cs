using Newtonsoft.Json;

namespace Synology.SurveillanceStation.Info.Results
{
    public class InfoResult
    {
        public InfoVersion Version { get; set; }
        public string Path { get; set; }
        public int? CustomizedPortHttp { get; set; }
        public int? CustomizedPortHttps { get; set; }
        public int CameraNumber { get; set; }
        public int LicenseNumber { get; set; }
        public int MaxCameraSupport { get; set; }
        public string Serial { get; set; }
        public bool IsAdmin { get; set; }
        [JsonProperty("userPriv")]
        public InfoUserPrivilege UserPrivilege { get; set; }
        public bool IsLicenseEnough { get; set; }
        public bool AllowSnapshot { get; set; }
        [JsonProperty("allowManualRec")]
        public bool AllowManualRecording { get; set; }
        [JsonProperty("allowDeleteRec")]
        public bool AllowDeleteRecording { get; set; }
    }
}

