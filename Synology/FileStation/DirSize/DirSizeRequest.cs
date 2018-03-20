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
		public ResultData<DirSizeStartResult> Start(DirSizeStartParameters parameters)
		{
            return this.GetData<DirSizeStartResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

        /// <summary>
        /// Status the specified parameters.
        /// </summary>
        /// <returns>The status.</returns>
        /// <param name="parameters">Parameters.</param>
		[RequestMethod("status")]
		public ResultData<DirSizeStatusResult> Status(DirSizeStatusParameters parameters)
		{
            return this.GetData<DirSizeStatusResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

        /// <summary>
        /// Stop the specified parameters.
        /// </summary>
        /// <returns>The stop.</returns>
        /// <param name="parameters">Parameters.</param>
		[RequestMethod("stop")]
		public ResultData Stop(DirSizeStatusParameters parameters)
		{
            return this.GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}