using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.DownloadStation.Task.Parameters
{
    /// <summary>
    /// Task list parameters.
    /// </summary>
	public class TaskListParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the additional.
        /// </summary>
        /// <value>The additional.</value>
		public TaskDetailsType? Additional { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
		[Required]
		public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>The limit.</value>
		[Required]
		public int Limit { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Synology.DownloadStation.Task.Parameters.TaskListParameters"/> class.
        /// </summary>
		public TaskListParameters()
		{
			Additional = null;
			Offset = 0;
			Limit = -1;
		}

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("offset", Offset),
				new QueryStringParameter("limit", Limit),
				new QueryStringParameter("additional", Additional)
			};
		}
	}
}

