﻿using System;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.CopyMove.Parameters;
using Synology.FileStation.CopyMove.Results;
using Synology.Parameters;

namespace Synology.FileStation.CopyMove
{
    /// <summary>
    /// Copy / Move operations from the Synology API
    /// This is a non-blocking API. You need to start to copy/move files with start method. Then, you should poll requests with status method to get the progress status, or make a request with stop method to cancel the operation.
    /// </summary>
    [Request("CopyMove")]
    internal class CopyMoveRequest : FileStationRequest, ICopyMoveRequest
    {
        public CopyMoveRequest(IFileStationApi parentApi) : base(parentApi)
        {
        }

        #region Obsolete
        /// <summary>
        /// Start to copy/move files.
        /// </summary>
        /// <param name="parameters">Parameters of the operation</param>
        [RequestMethod("start")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData<StartResult> Start(StartParameters parameters)
        {
            return this.GetData<StartResult>(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }

        /// <summary>
        /// Get the copying/moving status.
        /// </summary>
        [RequestMethod("status")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData<StatusResult> Status(StatusParameters parameters)
        {
            return this.GetData<StatusResult>(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }

        /// <summary>
        /// Stop a copy/move task.
        /// </summary>
        [RequestMethod("stop")]
        [Obsolete("It uses Result, migrate to Async methods")]
        public ResultData Stop(StopParameters parameters)
        {
            return this.GetData(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }
        #endregion

        /// <summary>
        /// Start to copy/move files.
        /// </summary>
        /// <param name="parameters">Parameters of the operation</param>
        [RequestMethod("start")]
        public async Task<ResultData<StartResult>> StartAsync(StartParameters parameters)
        {
            return await this.GetDataAsync<StartResult>(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }

        /// <summary>
        /// Get the copying/moving status.
        /// </summary>
        [RequestMethod("status")]
        public async Task<ResultData<StatusResult>> StatusAsync(StatusParameters parameters)
        {
            return await this.GetDataAsync<StatusResult>(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }

        /// <summary>
        /// Stop a copy/move task.
        /// </summary>
        [RequestMethod("stop")]
        public async Task<ResultData> StopAsync(StopParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }
    }
}
