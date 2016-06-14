using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Synology.Attributes;
using Synology.Utilities;

namespace Synology.Parameters
{
    public class SynologyParameters<T> where T : IParameter
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
        public T[] Additional { get; set; }

        public SynologyParameters()
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
