using System.Collections.Generic;
using System.Linq;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.DownloadStation.Task.Parameters
{
    /// <summary>
    /// Task delete parameters.
    /// </summary>
	public class TaskDeleteParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the identifiers.
        /// </summary>
        /// <value>The identifiers.</value>
		[Required]
		public string[] Ids { get; set; }
		/// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.DownloadStation.Task.Parameters.TaskDeleteParameters"/> force complete.
        /// </summary>
        /// <value><c>true</c> if force complete; otherwise, <c>false</c>.</value>
        public bool ForceComplete { get; set; }

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
				new QueryStringParameter("force_complete", ForceComplete)
			};
		}
	}
}
