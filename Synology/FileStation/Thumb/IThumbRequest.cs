﻿using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.Thumb.Parameters;
using Synology.Interfaces;

namespace Synology.FileStation.Thumb
{
    /// <summary>
    /// Thumb request.
    /// </summary>
    public interface IThumbRequest : ISynologyRequest
    {
        /// <summary>
        /// Get the specified parameters.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<byte[]>> GetAsync(ThumbGetParameters parameters);
    }
}