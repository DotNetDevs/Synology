using System;

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
