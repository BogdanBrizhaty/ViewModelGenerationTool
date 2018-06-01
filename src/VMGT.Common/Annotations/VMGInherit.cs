using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common.Annotations
{
    public sealed class VMGInherit : VMGAttributeBase
    {
        public string TypenameInheritFrom { get; }

        /// <summary>
        /// Specifies the type of MODEL in your project should be used to inherit it from
        /// </summary>
        /// <param name="inheritFromType">typeof Model</param>
        public VMGInherit(Type inheritFromType)
            :this(inheritFromType.Name)
        {
        }

        public VMGInherit(string inheritFromType)
            : base((int)Enums.AttributeExecutionPriority.Default, Enums.ReservedCommands.Inherit.ToString())
        {
            TypenameInheritFrom = inheritFromType;
        }

        // override to hide
        private VMGInherit()
        {

        }
    }
}
