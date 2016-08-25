using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using Synology.Enums;
using Synology.Attributes;

namespace Synology.Utilities
{
    public sealed class QueryStringParameter : GenericParameter
    {
        public QueryStringParameter(string name, string value, int minVersion = 1, bool surroundBrackets = false) : base(name, value, minVersion, surroundBrackets)
        {
        }

        private static string GetEnumDescription(Enum value)
        {
            if (value == null) return null;

            var type = value.GetType().GetTypeInfo();
            var res = value.ToString();

            if (type.CustomAttributes.Any(t => t.AttributeType == typeof(FlagsAttribute)))
            {
                var members = type.AsType().GetMembers();
                var conversion = members.SelectMany(t => t.GetCustomAttributes(typeof(DescriptionAttribute), false).Select(a => new KeyValuePair<string, string>(t.Name, ((DescriptionAttribute)a).Description))).ToDictionary(t => t.Key, t => t.Value);

                res = string.Join(",", res.Split(',').Select(t => t.Trim()).Select(t => conversion.ContainsKey(t) ? conversion[t] : t));
            }
            else
            {
                var memInfo = type.AsType().GetMember(value.ToString());

                if (memInfo.Length > 0)
                {
                    var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                    if (attrs.Count() > 0)
                        res = ((DescriptionAttribute)attrs.First()).Description;
                }
            }

            return res;
        }

        private static string GetSortDirectionDescription(ListSortDirection? value)
        {
            if (value == null)
                return null;

            if (value == ListSortDirection.Ascending)
                return "asc";

            if (value == ListSortDirection.Descending)
                return "desc";

            return null;
        }

        public QueryStringParameter(string name, ListSortDirection? value, int minVersion = 1) : this(name, GetSortDirectionDescription(value), minVersion)
        {
        }

        public QueryStringParameter(string name, Enum value, int minVersion = 1) : this(name, GetEnumDescription(value), minVersion)
        {
        }

        public QueryStringParameter(string name, Enum value, bool surroundBrackets, int minVersion = 1) : this(name, GetEnumDescription(value), minVersion, surroundBrackets)
        {
        }

        public QueryStringParameter(string name, int? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, double? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, float? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, decimal? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, long? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, short? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, bool value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, char value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, uint? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, ulong? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, ushort? value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, IEnumerable value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, IEnumerable value, string separator, int minVersion = 1) : base(name, value, separator, minVersion)
        {
        }

        public QueryStringParameter(string name, IEnumerable<string> value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public QueryStringParameter(string name, IEnumerable<string> value, bool surroundBrackets, int minVersion = 1) : base(name, value, surroundBrackets, minVersion)
        {
        }

        public QueryStringParameter(string name, IEnumerable<string> value, string separator, int minVersion = 1) : base(name, value, separator, minVersion)
        {
        }

        public QueryStringParameter(string name, object value, int minVersion = 1) : base(name, value, minVersion)
        {
        }

        public override string ToString()
        {
            return Empty ? string.Empty : $"{Name}={Value}";
        }
    }
}
