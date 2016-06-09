using Synology.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Synology.Attributes;

namespace Synology.Classes
{
    public class SynologyRequestParameters
    {
        private string _method;

        public string Method
        {
            get
            {
                return _method;
            }
            set
            {
                _method = _method ?? value;
            }
        }
        public int Version { get; set; }
        public QueryStringParameter[] Additional { get; set; }

        public SynologyRequestParameters()
        {
            var st = new StackTrace();
            var method = st.GetFrames()?.Select(t => t.GetMethod()).FirstOrDefault(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));

            if (method != null)
            {
                var attr = method.GetCustomAttribute(typeof(RequestMethodAttribute)) as RequestMethodAttribute;

                Method = attr?.Name;
            }

            Version = 1;
        }
    }
}
