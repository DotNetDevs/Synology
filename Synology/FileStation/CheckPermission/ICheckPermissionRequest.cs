using Synology.Classes;
using Synology.Interfaces;
using Synology.FileStation.CheckPermission.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.CheckPermission
{
    /// <summary>
    /// Check permission request.
    /// </summary>
    public interface ICheckPermissionRequest : ISynologyRequest
	{
        /// <summary>
        /// Write the specified parameters.
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> WriteAsync(CheckPermissionWriteParameters parameters);
	}
}