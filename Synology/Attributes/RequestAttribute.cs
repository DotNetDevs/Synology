using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class RequestAttribute : Attribute
    {
        public string Name { get; }
        public RequestAttribute(string name)
        {
            Name = name;
        }
    }
}
