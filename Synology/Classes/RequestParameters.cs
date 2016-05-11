using System;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace Synology.Classes
{
	public abstract class RequestParameters : IValidatableObject
	{
		public abstract QueryStringParameter[] Parameters();

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			return Enumerable.Empty<ValidationResult>();
		}

		public static implicit operator QueryStringParameter[] (RequestParameters parameters)
		{
			var results = new List<ValidationResult>();
			var isValid = Validator.TryValidateObject(parameters, new ValidationContext(parameters, null, null), results, true);

			if (isValid)
				return parameters?.Parameters();

			var message = $"Errors:{Environment.NewLine}{string.Join(Environment.NewLine, results.Select(t => $"{string.Join(",", t.MemberNames)}: {t.ErrorMessage}"))}";

			throw new ValidationException(message);
		}
	}
}