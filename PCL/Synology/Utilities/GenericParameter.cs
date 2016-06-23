using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Synology.Utilities
{
    public abstract class GenericParameter : IParameter
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Value of the parameter
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Constructs a FormParameter
        /// </summary>
        /// <param name="name">Name of the parameter</param>
        /// <param name="value">Value of the parameter</param>
        /// <param name="surroundBrackets">Surround parameter value(s) by brackets</param>
        protected GenericParameter(string name, string value, bool surroundBrackets = false)
        {
            Name = name;
            Value = surroundBrackets ? $"[{value}]" : value;
        }

        protected GenericParameter(string name, int? value) : this(name, value?.ToString())
        {
        }

        protected GenericParameter(string name, double? value) : this(name, value?.ToString(CultureInfo.InvariantCulture))
        {
        }

        protected GenericParameter(string name, float? value) : this(name, value?.ToString(CultureInfo.InvariantCulture))
        {
        }

        protected GenericParameter(string name, decimal? value) : this(name, value?.ToString(CultureInfo.InvariantCulture))
        {
        }

        protected GenericParameter(string name, long? value) : this(name, value?.ToString())
        {
        }

        protected GenericParameter(string name, short? value) : this(name, value?.ToString())
        {
        }

        protected GenericParameter(string name, bool value) : this(name, value.ToString())
        {
        }

        protected GenericParameter(string name, char value) : this(name, value.ToString())
        {
        }

        protected GenericParameter(string name, uint? value) : this(name, value?.ToString())
        {
        }

        protected GenericParameter(string name, ulong? value) : this(name, value?.ToString())
        {
        }

        protected GenericParameter(string name, ushort? value) : this(name, value?.ToString())
        {
        }

        protected GenericParameter(string name, IEnumerable value) : this(name, value, ",")
        {
        }

        protected GenericParameter(string name, IEnumerable value, string separator) : this(name, string.Join(separator, value.Cast<object>().Select(t => t.ToString())))
        {
        }

        protected GenericParameter(string name, IEnumerable<string> value) : this(name, value, ",")
        {
        }

        protected GenericParameter(string name, IEnumerable<string> value, bool surroundBrackets) : this(name, value, ",", surroundBrackets)
        {
        }

        protected GenericParameter(string name, IEnumerable<string> value, string separator) : this(name, string.Join(separator, value))
        {
        }

        protected GenericParameter(string name, IEnumerable<string> value, string separator, bool surroundBrackets) : this(name, string.Join(separator, value), surroundBrackets)
        {
        }

        protected GenericParameter(string name, object value) : this(name, value?.ToString())
        {
        }

        /// <summary>
        /// Is the parameter empty
        /// </summary>
        public virtual bool Empty => string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Value);
    }
}
