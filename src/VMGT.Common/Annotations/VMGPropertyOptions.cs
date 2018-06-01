using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common.Annotations
{
    public sealed class VMGPropertyOptions : VMGAttributeBase
    {
        public Enums.PropertyType PropertyType { get; }
        public string PropertyName { get; set; }

        public VMGPropertyOptions(Enums.PropertyType propertyType)
            :base((int)Enums.AttributeExecutionPriority.Default, Enums.ReservedCommands.PropertyOptions)
        {
            PropertyType = propertyType;
        }

        private VMGPropertyOptions()
        {

        }
    }
}
