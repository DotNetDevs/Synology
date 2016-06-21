using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Synology.Attributes;
using Synology.Utilities;
using System;

namespace Synology.Parameters
{
    public class SynologyParameters<T> where T : IParameter
    {
        public string Method { get; }
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
            else
            {
                throw new Exception("MethodAttribute missing in the invoking method.");
            }

            Version = 1;
        }
    }
}
