using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Demo summary
/// </summary>
namespace VMGT.Common.Annotations
{
    /// <summary>
    /// Base class with AttributrePriority set.
    /// </summary>
    public abstract class VMGAttributeBase : Attribute
    {
        public int AttributePriority { get; }
        public string AttributeCommandAlias { get; }

        internal protected VMGAttributeBase(int priority, string cmdAlias)
        {
            AttributePriority = priority;
            AttributeCommandAlias = cmdAlias;
        }

        internal VMGAttributeBase(int priority, Enums.ReservedCommands cmdAlias)
            :this(priority, cmdAlias.ToString().ToLower())
        {
        }

        protected VMGAttributeBase()
        {
            //var pt = Enums.PropertyType.
        }
    }
}
