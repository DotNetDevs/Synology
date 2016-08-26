using System;

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
