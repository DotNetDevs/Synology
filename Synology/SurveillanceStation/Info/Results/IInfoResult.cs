namespace Synology.SurveillanceStation.Info.Results
{
    /// <summary>
    /// Info result.
    /// </summary>
    public interface IInfoResult
    {
        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        IInfoVersionResult Version { get; }
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        string Path { get; }
        /// <summary>
        /// Gets the customized port http.
        /// </summary>
        /// <value>The customized port http.</value>
        int? CustomizedPortHttp { get; }
        /// <summary>
        /// Gets the customized port https.
        /// </summary>
        /// <value>The customized port https.</value>
        int? CustomizedPortHttps { get; }
        /// <summary>
        /// Gets the camera number.
        /// </summary>
        /// <value>The camera number.</value>
        int CameraNumber { get; }
        /// <summary>
        /// Gets the license number.
        /// </summary>
        /// <value>The license number.</value>
        int LicenseNumber { get; }
        /// <summary>
        /// Gets the max camera support.
        /// </summary>
        /// <value>The max camera support.</value>
        int MaxCameraSupport { get; }
        /// <summary>
        /// Gets the serial.
        /// </summary>
        /// <value>The serial.</value>
        string Serial { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.SurveillanceStation.Info.Results.IInfoResult"/>
        /// is admin.
        /// </summary>
        /// <value><c>true</c> if is admin; otherwise, <c>false</c>.</value>
        bool IsAdmin { get; }
        /// <summary>
        /// Gets the user privilege.
        /// </summary>
        /// <value>The user privilege.</value>
        InfoUserPrivilege UserPrivilege { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.SurveillanceStation.Info.Results.IInfoResult"/>
        /// is license enough.
        /// </summary>
        /// <value><c>true</c> if is license enough; otherwise, <c>false</c>.</value>
        bool IsLicenseEnough { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.SurveillanceStation.Info.Results.IInfoResult"/>
        /// allow snapshot.
        /// </summary>
        /// <value><c>true</c> if allow snapshot; otherwise, <c>false</c>.</value>
        bool AllowSnapshot { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.SurveillanceStation.Info.Results.IInfoResult"/>
        /// allow manual recording.
        /// </summary>
        /// <value><c>true</c> if allow manual recording; otherwise, <c>false</c>.</value>
        bool AllowManualRecording { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.SurveillanceStation.Info.Results.IInfoResult"/>
        /// allow delete recording.
        /// </summary>
        /// <value><c>true</c> if allow delete recording; otherwise, <c>false</c>.</value>
        bool AllowDeleteRecording { get; }
    }
}