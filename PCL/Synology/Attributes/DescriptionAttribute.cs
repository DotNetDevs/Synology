using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Attributes
{
    //TODO: Created for fixing PCL project
    /// <summary>
    ///    <para>Specifies a description for a property
    ///       or event.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {
        /// <summary>
        /// <para>Specifies the default value for the <see cref='System.ComponentModel.DescriptionAttribute'/> , which is an
        ///    empty string (""). This <see langword='static'/> field is read-only.</para>
        /// </summary>
        public static readonly DescriptionAttribute Default = new DescriptionAttribute();

        /// <summary>
        ///    <para>[To be supplied.]</para>
        /// </summary>
        public DescriptionAttribute() : this(string.Empty)
        {
        }

        /// <summary>
        ///    <para>Initializes a new instance of the <see cref='System.ComponentModel.DescriptionAttribute'/> class.</para>
        /// </summary>
        public DescriptionAttribute(string description)
        {
            DescriptionValue = description;
        }

        /// <summary>
        ///    <para>Gets the description stored in this attribute.</para>
        /// </summary>
        public virtual string Description => DescriptionValue;

        /// <summary>
        ///     Read/Write property that directly modifies the string stored
        ///     in the description attribute. The default implementation
        ///     of the Description property simply returns this value.
        /// </summary>
        protected string DescriptionValue { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            var other = obj as DescriptionAttribute;
            return (other != null) && other.Description == Description;
        }

        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }
    }
}
