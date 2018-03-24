using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Synology.Parameters;

namespace Synology.DownloadStation.Task.Parameters
{
    /// <summary>
    /// Task info parameters.
    /// </summary>
	public class TaskInfoParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the identifiers.
        /// </summary>
        /// <value>The identifiers.</value>
		[Required]
		public string[] Ids { get; set; }

        /// <summary>
        /// Gets or sets the additional.
        /// </summary>
        /// <value>The additional.</value>
		public TaskDetailsType? Additional { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Synology.DownloadStation.Task.Parameters.TaskInfoParameters"/> class.
        /// </summary>
		public TaskInfoParameters()
		{
			Additional = null;
		}

        /// <summary>
        /// Validate the specified validationContext.
        /// </summary>
        /// <returns>The validate.</returns>
        /// <param name="validationContext">Validation context.</param>
		public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			var result = base.Validate(validationContext).ToList();

			if (Ids.Length <= 0)
				result.Add(new ValidationResult("Ids collection cannot be empty", new[] { "Ids" }));

			return result;
		}

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("id", Ids),
				new QueryStringParameter("additional", Additional)
			};
		}

	}
}

