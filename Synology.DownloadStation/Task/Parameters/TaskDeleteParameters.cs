using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.DownloadStation.Task.Parameters
{
	public class TaskDeleteParameters : RequestParameters
	{
		[Required]
		public string[] Ids { get; set; }
		public bool ForceComplete { get; set; }

		public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			var result = base.Validate(validationContext).ToList();

			if (Ids.Length <= 0)
				result.Add(new ValidationResult("Ids collection cannot be empty", new[] { "Ids" }));

			return result;
		}

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("id", Ids),
				new QueryStringParameter("force_complete", ForceComplete)
			};
		}
	}
}
