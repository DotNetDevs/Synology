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
        public FormParameter(string name, string value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, int? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, double? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, float? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, decimal? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, long? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, short? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, bool value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, char value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, uint? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, ulong? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, ushort? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, IEnumerable value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, IEnumerable value, string separator, int minVersion = 1) : base(name, value, separator, minVersion)
        {
        }

        public FormParameter(string name, IEnumerable<string> value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string name, IEnumerable<string> value, string separator, int minVersion = 1) : base(name, value, separator, minVersion)
        {
        }

        public FormParameter(string name, object value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public FormParameter(string parameterName, bool? parameterValue, int minVersion = 1) : this(parameterName, parameterValue?.ToString().ToLowerInvariant() ?? "(None)", minVersion)
        {
        }

        public FormParameter(string parameterName, DateTime parameterValue, int minVersion = 1) : this(parameterName, parameterValue.ToUnixTimeStamp(), minVersion)
        {
        }
    }
}
