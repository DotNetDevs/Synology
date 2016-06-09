using Synology.Extensions;
using System;

namespace Synology.Utilities
{
    /// <summary>
    /// A form parameter used to send data in a post request
    /// </summary>
    public class FormParameter
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Value of the parameter
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Constructs a FormParameter
        /// </summary>
        /// <param name="parameterName">Name of the parameter</param>
        /// <param name="parameterValue">Value of the parameter</param>
        public FormParameter(string parameterName, string parameterValue)
        {
            Name = parameterName;
            Value = parameterValue;
        }

        public FormParameter(string parameterName, bool parameterValue) : this(parameterName, parameterValue.ToString().ToLowerInvariant())
        {
        }

        public FormParameter(string parameterName, bool? parameterValue) : this(parameterName, parameterValue.HasValue ? parameterValue.Value.ToString().ToLowerInvariant() : "(None)")
        {
        }

        public FormParameter(string parameterName, int parameterValue) : this(parameterName, parameterValue.ToString())
        {
        }

        public FormParameter(string parameterName, DateTime parameterValue) : this(parameterName, parameterValue.ToUnixTimeStamp())
        {
        }

        /// <summary>
        /// Is the parameter empty
        /// </summary>
        public virtual bool IsEmpty => string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Value);
    }
}
