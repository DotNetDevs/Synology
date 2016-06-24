﻿using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Synology.Parameters;

namespace Synology.DownloadStation.Task.Parameters
{
	public class TaskInfoParameters : RequestParameters
	{
		[Required]
		public string[] Ids { get; set; }

		public TaskDetailsType? Additional { get; set; }

		public TaskInfoParameters()
		{
			Additional = null;
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
				new QueryStringParameter("additional", Additional)
			};
		}

	}
}

