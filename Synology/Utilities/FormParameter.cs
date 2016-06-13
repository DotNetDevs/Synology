using Synology.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Synology.Utilities
{
    /// <summary>
    /// A form parameter used to send data in a post request
    /// </summary>
    public class FormParameter : GenericParameter
    {
        public FormParameter(string name, string value) : base(name, value)
        {
        }

        public FormParameter(string name, int? value) : base(name, value)
        {
        }

        public FormParameter(string name, double? value) : base(name, value)
        {
        }

        public FormParameter(string name, float? value) : base(name, value)
        {
        }

        public FormParameter(string name, decimal? value) : base(name, value)
        {
        }

        public FormParameter(string name, long? value) : base(name, value)
        {
        }

        public FormParameter(string name, short? value) : base(name, value)
        {
        }

        public FormParameter(string name, bool value) : base(name, value)
        {
        }

        public FormParameter(string name, char value) : base(name, value)
        {
        }

        public FormParameter(string name, uint? value) : base(name, value)
        {
        }

        public FormParameter(string name, ulong? value) : base(name, value)
        {
        }

        public FormParameter(string name, ushort? value) : base(name, value)
        {
        }

        public FormParameter(string name, IEnumerable value) : base(name, value)
        {
        }

        public FormParameter(string name, IEnumerable value, string separator) : base(name, value, separator)
        {
        }

        public FormParameter(string name, IEnumerable<string> value) : base(name, value)
        {
        }

        public FormParameter(string name, IEnumerable<string> value, string separator) : base(name, value, separator)
        {
        }

        public FormParameter(string name, object value) : base(name, value)
        {
        }

        public FormParameter(string parameterName, bool? parameterValue) : this(parameterName, parameterValue?.ToString().ToLowerInvariant() ?? "(None)")
        {
        }

        public FormParameter(string parameterName, DateTime parameterValue) : this(parameterName, parameterValue.ToUnixTimeStamp())
        {
        }
    }
}
