using System;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.DirSize.Parameters;
using Synology.FileStation.DirSize.Results;
using Synology.Parameters;

namespace Synology.FileStation.DirSize
{
    /// <summary>
    /// Dir size request.
    /// </summary>
	[Request("DirSize")]
    internal class DirSizeRequest : FileStationRequest, IDirSizeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Synology.FileStation.DirSize.DirSizeRequest"/> class.
        /// </summary>
        /// <param name="api">API.</param>
        public DirSizeRequest(IFileStationApi api) : base(api)
        {
        }

        /// <summary>
        /// Start the specified parameters.
        /// </summary>
        /// <returns>The start.</returns>
        /// <param name="parameters">Parameters.</param>
        [RequestMethod("start")]
        public async Task<ResultData<IDirSizeStartResult>> StartAsync(DirSizeStartParameters parameters)
        {
            return ResultData<IDirSizeStartResult>.From(await this.GetDataAsync<DirSizeStartResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            }));
        }

        /// <summary>
        /// Status the specified parameters.
        /// </summary>
        /// <returns>The status.</returns>
        /// <param name="parameters">Parameters.</param>
        [RequestMethod("status")]
        public async Task<ResultData<IDirSizeStatusResult>> StatusAsync(DirSizeStatusParameters parameters)
        {
            return ResultData<IDirSizeStatusResult>.From(await this.GetDataAsync<DirSizeStatusResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            }));
        }

        /// <summary>
        /// Stop the specified parameters.
        /// </summary>
        /// <returns>The stop.</returns>
        /// <param name="parameters">Parameters.</param>
        [RequestMethod("stop")]
        public async Task<ResultData> StopAsync(DirSizeStatusParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
    }
}