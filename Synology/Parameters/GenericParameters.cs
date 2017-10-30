using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Synology.Utilities;

namespace Synology.Parameters
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class GenericParameters<T> : IValidatableObject where T : IParameter
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract T[] Parameters();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="validationContext"></param>
		/// <returns></returns>
		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => Enumerable.Empty<ValidationResult>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		public static implicit operator T[] (GenericParameters<T> parameters)
		{
			var results = new List<ValidationResult>();
			var isValid = Validator.TryValidateObject(parameters, new ValidationContext(parameters, null, null), results, true);

			if (isValid) return parameters.Parameters();

			throw new ValidationException($"Errors:{Environment.NewLine}{string.Join(Environment.NewLine, results.Select(t => $"{string.Join(",", t.MemberNames)}: {t.ErrorMessage}"))}");
		}
	}
}
