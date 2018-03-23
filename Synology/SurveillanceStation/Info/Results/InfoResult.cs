using Newtonsoft.Json;

namespace Synology.SurveillanceStation.Info.Results
{
    /// <summary>
    /// Info result.
    /// </summary>
    internal class InfoResult : IInfoResult
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        [JsonProperty("version")]
        public InfoVersionResult Version { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the customized port http.
        /// </summary>
        /// <value>The customized port http.</value>
        [JsonProperty("customizedPortHttp")]
        public int? CustomizedPortHttp { get; set; }

        /// <summary>
        /// Gets or sets the customized port https.
        /// </summary>
        /// <value>The customized port https.</value>
        [JsonProperty("customizedPortHttps")]
        public int? CustomizedPortHttps { get; set; }

        /// <summary>
        /// Gets or sets the camera number.
        /// </summary>
        /// <value>The camera number.</value>
        [JsonProperty("cameraNumber")]
        public int CameraNumber { get; set; }

        /// <summary>
        /// Gets or sets the license number.
        /// </summary>
        /// <value>The license number.</value>
        [JsonProperty("licenseNumber")]
        public int LicenseNumber { get; set; }

        /// <summary>
        /// Gets or sets the max camera support.
        /// </summary>
        /// <value>The max camera support.</value>
        [JsonProperty("maxCameraSupport")]
        public int MaxCameraSupport { get; set; }

        /// <summary>
        /// Gets or sets the serial.
        /// </summary>
        /// <value>The serial.</value>
        [JsonProperty("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.SurveillanceStation.Info.Results.InfoResult"/> is admin.
        /// </summary>
        /// <value><c>true</c> if is admin; otherwise, <c>false</c>.</value>
        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets the user privilege.
        /// </summary>
        /// <value>The user privilege.</value>
        [JsonProperty("userPriv")]
        public InfoUserPrivilege UserPrivilege { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.SurveillanceStation.Info.Results.InfoResult"/> is license enough.
        /// </summary>
        /// <value><c>true</c> if is license enough; otherwise, <c>false</c>.</value>
        [JsonProperty("isLicenseEnough")]
        public bool IsLicenseEnough { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.SurveillanceStation.Info.Results.InfoResult"/> allow snapshot.
        /// </summary>
        /// <value><c>true</c> if allow snapshot; otherwise, <c>false</c>.</value>
        [JsonProperty("allowSnapshot")]
        public bool AllowSnapshot { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.SurveillanceStation.Info.Results.InfoResult"/> allow manual recording.
        /// </summary>
        /// <value><c>true</c> if allow manual recording; otherwise, <c>false</c>.</value>
        [JsonProperty("allowManualRec")]
        public bool AllowManualRecording { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.SurveillanceStation.Info.Results.InfoResult"/> allow delete recording.
        /// </summary>
        /// <value><c>true</c> if allow delete recording; otherwise, <c>false</c>.</value>
        [JsonProperty("allowDeleteRec")]
        public bool AllowDeleteRecording { get; set; }

        IInfoVersionResult IInfoResult.Version => Version;
    }
}

