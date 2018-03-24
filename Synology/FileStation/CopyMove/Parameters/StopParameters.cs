using Synology.Parameters;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Synology.FileStation.CopyMove.Parameters
{
    /// <summary>
    /// Stop parameters.
    /// </summary>
    public class StopParameters : RequestParameters
    {
        /// <summary>
        /// The task id to be stopped.
        /// </summary>
        /// <remarks>
        /// A unique ID for the copy/move task which is obtained from start method.
        /// </remarks>
        [Required]
        public string TaskId { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("taskid", TaskId)
            };
        }
    }
}
