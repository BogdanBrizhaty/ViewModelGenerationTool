using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common.Exceptions
{
    public class AttributeHasNoAliasException : Exception
    {
        public AttributeHasNoAliasException(Type type)
            :base("Attribute " + type.FullName + " has no alias")
        {
               
        }
    }
}
