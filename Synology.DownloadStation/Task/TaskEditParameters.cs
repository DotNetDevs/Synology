using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Synology.DownloadStation.Task
{
	public class TaskEditParameters : RequestParameters
	{
		[Required]
		public string[] Ids { get; set; }
		public string Destination { get; set; }

		public TaskEditParameters()
		{
			Destination = null;
		}

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
				new QueryStringParameter("destination", Destination)
			};
		}
	}
}
