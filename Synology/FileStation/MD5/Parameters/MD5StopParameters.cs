using Synology.Parameters;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
namespace Synology.FileStation.MD5.Parameters
{
    /// <summary>
    /// MD 5 stop parameters.
    /// </summary>
	public class MD5StopParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the task identifier.
        /// </summary>
        /// <value>The task identifier.</value>
		[Required]
		public string TaskID { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("taskid", TaskID)
			};
		}
	}
}

