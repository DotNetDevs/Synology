using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RequestMethodAttribute : Attribute
    {
        public readonly string Name;

        public RequestMethodAttribute(string name)
        {
            Name = name;
        }
    }
}
