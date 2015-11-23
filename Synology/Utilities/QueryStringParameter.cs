using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Utilities
{
	public sealed class QueryStringParameter
	{
		private readonly string _name;
		private readonly string _value;

		public bool Empty => string.IsNullOrWhiteSpace(_name) || string.IsNullOrWhiteSpace(_value);

		public QueryStringParameter(string name, string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return;

			_name = name;
			_value = value;
		}

		public override string ToString()
		{
			return Empty ? string.Empty : $"{_name}={_value}";
		}

		public QueryStringParameter(string name, int? value) : this(name, value?.ToString())
		{
		}

		public QueryStringParameter(string name, double? value) : this(name, value?.ToString(CultureInfo.InvariantCulture))
		{
		}

		public QueryStringParameter(string name, float? value) : this(name, value?.ToString(CultureInfo.InvariantCulture))
		{
		}

		public QueryStringParameter(string name, decimal? value) : this(name, value?.ToString(CultureInfo.InvariantCulture))
		{
		}

		public QueryStringParameter(string name, long? value) : this(name, value?.ToString())
		{
		}

		public QueryStringParameter(string name, short? value) : this(name, value?.ToString())
		{
		}

		public QueryStringParameter(string name, bool value) : this(name, value.ToString())
		{
		}

		public QueryStringParameter(string name, char value) : this(name, value.ToString())
		{
		}

		public QueryStringParameter(string name, uint? value) : this(name, value?.ToString())
		{
		}

		public QueryStringParameter(string name, ulong? value) : this(name, value?.ToString())
		{
		}

		public QueryStringParameter(string name, ushort? value) : this(name, value?.ToString())
		{
		}

		public QueryStringParameter(string name, IEnumerable value) : this(name, value, ",")
		{
		}

		public QueryStringParameter(string name, IEnumerable value, string separator) : this(name, string.Join(separator, value))
		{
		}

		public QueryStringParameter(string name, object value) : this(name, value?.ToString())
		{
		}
	}
}
