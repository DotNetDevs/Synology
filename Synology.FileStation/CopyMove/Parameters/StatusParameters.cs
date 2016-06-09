using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Synology.FileStation.CopyMove.Parameters
{
    public class StatusParameters : RequestParameters
    {
        /// <summary>
        /// The task id from which status has to be retrieved.
        /// </summary>
        /// <remarks>
        /// A unique ID for the copy/move task which is obtained from start method.
        /// </remarks>
        [Required]
        public string TaskId { get; set; }

        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("taskid", TaskId)
            };
        }
    }
}
