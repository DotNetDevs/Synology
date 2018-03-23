using System.Collections.Generic;

namespace Synology.FileStation.Info.Results
{
    /// <summary>
    /// Info result.
    /// </summary>
    public interface IInfoResult
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.IInfoResult"/> enable
        /// list usergrp.
        /// </summary>
        /// <value><c>true</c> if enable list usergrp; otherwise, <c>false</c>.</value>
        bool EnableListUsergrp { get; }
        /// <summary>
        /// Gets the hostname.
        /// </summary>
        /// <value>The hostname.</value>
        string Hostname { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.IInfoResult"/> is manager.
        /// </summary>
        /// <value><c>true</c> if is manager; otherwise, <c>false</c>.</value>
        bool IsManager { get; }
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>The items.</value>
        IEnumerable<IInfoItemResult> Items { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.IInfoResult"/> support
        /// file request.
        /// </summary>
        /// <value><c>true</c> if support file request; otherwise, <c>false</c>.</value>
        bool SupportFileRequest { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Info.Results.IInfoResult"/> support sharing.
        /// </summary>
        /// <value><c>true</c> if support sharing; otherwise, <c>false</c>.</value>
        bool SupportSharing { get; }
        /// <summary>
        /// Gets the support vfs.
        /// </summary>
        /// <value>The support vfs.</value>
        string SupportVfs { get; }
        /// <summary>
        /// Gets the support virtual.
        /// </summary>
        /// <value>The support virtual.</value>
        IInfoSupportVirtualResult SupportVirtual { get; }
        /// <summary>
        /// Gets the support virtual protocol.
        /// </summary>
        /// <value>The support virtual protocol.</value>
        string SupportVirtualProtocol { get; }
        /// <summary>
        /// Gets the system codepage.
        /// </summary>
        /// <value>The system codepage.</value>
        string SystemCodepage { get; }
        /// <summary>
        /// Gets the uid.
        /// </summary>
        /// <value>The uid.</value>
        int Uid { get; }
    }
}