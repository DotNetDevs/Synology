using Synology.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Classes
{
    public abstract class PostParameters : IValidatableObject
    {
        public abstract FormParameter[] Parameters();

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }

        public static implicit operator FormParameter[] (PostParameters parameters)
        {
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(parameters, new ValidationContext(parameters, null, null), results, true);

            if (isValid)
                return parameters.Parameters();

            var message = $"Errors:{Environment.NewLine}{string.Join(Environment.NewLine, results.Select(t => $"{string.Join(",", t.MemberNames)}: {t.ErrorMessage}"))}";

            throw new ValidationException(message);
        }
    }
}
