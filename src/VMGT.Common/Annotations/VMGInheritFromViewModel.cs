using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common.Annotations
{
    public sealed class VMGInheritFromViewModel : VMGAttributeBase
    {
        public string TypenameInheritFrom { get; }

        public VMGInheritFromViewModel(string inheritFromType)
            : base((int)Enums.AttributeExecutionPriority.Default, Enums.ReservedCommands.Inherit.ToString())
        {
            TypenameInheritFrom = inheritFromType;
        }

        // override to hide
        private VMGInheritFromViewModel()
        {

        }
    }
}
