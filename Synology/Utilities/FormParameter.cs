using Synology.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Synology.Utilities
{
    /// <inheritdoc />
    /// <summary>
    /// A form parameter used to send data in a post request
    /// </summary>
    public class FormParameter : GenericParameter
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, string value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, int? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, double? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, float? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, decimal? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, long? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, short? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, bool value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, char value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, uint? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, ulong? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, ushort? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, IEnumerable value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="separator"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, IEnumerable value, string separator, int minVersion = 1) : base(name, value, separator, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, IEnumerable<string> value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="separator"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, IEnumerable<string> value, string separator, int minVersion = 1) : base(name, value, separator, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string name, object value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string parameterName, bool? parameterValue, int minVersion = 1) : this(parameterName, parameterValue?.ToString().ToLowerInvariant() ?? "(None)", minVersion)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        /// <param name="minVersion"></param>
        public FormParameter(string parameterName, DateTime parameterValue, int minVersion = 1) : this(parameterName, parameterValue.ToUnixTimeStamp(), minVersion)
        {
        }
    }
}
