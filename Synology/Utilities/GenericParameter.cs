using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Synology.Utilities
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class GenericParameter : IParameter
	{
		/// <inheritdoc />
		/// <summary>
		/// Name of the parameter
		/// </summary>
		public string Name { get; }
		/// <inheritdoc />
		/// <summary>
		/// Value of the parameter
		/// </summary>
		public string Value { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public int MinVersion { get; }

		/// <summary>
		/// Constructs a FormParameter
		/// </summary>
		/// <param name="name">Name of the parameter</param>
		/// <param name="value">Value of the parameter</param>
		/// <param name="surroundBrackets">Surround parameter value(s) by brackets</param>
		/// <param name="minVersion">The minimum version of the parameter</param>
		protected GenericParameter(string name, string value, int minVersion = 1, bool surroundBrackets = false)
		{
			Name = name;
			Value = surroundBrackets ? $"[{value}]" : value;
			MinVersion = minVersion;
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, int? value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, double? value, int minVersion = 1) : this(name, value?.ToString(CultureInfo.InvariantCulture), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, float? value, int minVersion = 1) : this(name, value?.ToString(CultureInfo.InvariantCulture), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, decimal? value, int minVersion = 1) : this(name, value?.ToString(CultureInfo.InvariantCulture), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, long? value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, short? value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, bool value, int minVersion = 1) : this(name, value.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, char value, int minVersion = 1) : this(name, value.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, uint? value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, ulong? value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, ushort? value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, IEnumerable value, int minVersion = 1) : this(name, value, ",", minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="separator"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, IEnumerable value, string separator, int minVersion = 1) : this(name, string.Join(separator, value.Cast<object>().Select(t => t.ToString())), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, IEnumerable<string> value, int minVersion = 1) : this(name, value, ",", minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="surroundBrackets"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, IEnumerable<string> value, bool surroundBrackets, int minVersion = 1) : this(name, value, ",", surroundBrackets, minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="separator"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, IEnumerable<string> value, string separator, int minVersion = 1) : this(name, string.Join(separator, value), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="separator"></param>
		/// <param name="surroundBrackets"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, IEnumerable<string> value, string separator, bool surroundBrackets, int minVersion = 1) : this(name, string.Join(separator, value), minVersion, surroundBrackets)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="minVersion"></param>
		protected GenericParameter(string name, object value, int minVersion = 1) : this(name, value?.ToString(), minVersion)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// Is the parameter empty
		/// </summary>
		public virtual bool Empty => string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Value);
	}
}
