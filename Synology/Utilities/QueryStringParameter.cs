using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ComponentModel;

namespace Synology.Utilities
{
    public sealed class QueryStringParameter : GenericParameter
    {
        public QueryStringParameter(string name, string value) : base(name, value)
        {
        }

        public static string GetEnumDescription(Enum value)
        {
            if (value == null) return null;

            var type = value.GetType();
            var res = value.ToString();

            if (type.CustomAttributes.Any(t => t.AttributeType == typeof(FlagsAttribute)))
            {
                var members = type.GetMembers();
                var conversion = members.SelectMany(t => t.GetCustomAttributes(typeof(DescriptionAttribute), false).Select(a => new KeyValuePair<string, string>(t.Name, ((DescriptionAttribute)a).Description))).ToDictionary(t => t.Key, t => t.Value);

                res = string.Join(",", res.Split(',').Select(t => t.Trim()).Select(t => conversion.ContainsKey(t) ? conversion[t] : t));
            }
            else
            {
                var memInfo = type.GetMember(value.ToString());

                if (memInfo.Length > 0)
                {
                    var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                    if (attrs.Length > 0)
                        res = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return res;
        }

        public static string GetSortDirectionDescription(ListSortDirection? value)
        {
            if (value == null)
                return null;

            if (value == ListSortDirection.Ascending)
                return "asc";

            if (value == ListSortDirection.Descending)
                return "desc";

            return null;
        }

        public QueryStringParameter(string name, ListSortDirection? value) : this(name, GetSortDirectionDescription(value))
        {
        }

        public QueryStringParameter(string name, Enum value) : this(name, GetEnumDescription(value))
        {
        }

        public QueryStringParameter(string name, int? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, double? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, float? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, decimal? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, long? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, short? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, bool value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, char value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, uint? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, ulong? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, ushort? value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, IEnumerable value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, IEnumerable value, string separator) : base(name, value, separator)
        {
        }

        public QueryStringParameter(string name, IEnumerable<string> value) : base(name, value)
        {
        }

        public QueryStringParameter(string name, IEnumerable<string> value, string separator) : base(name, value, separator)
        {
        }

        public QueryStringParameter(string name, object value) : base(name, value)
        {
        }

        public override string ToString()
        {
            return Empty ? string.Empty : $"{Name}={Value}";
        }
    }
}
