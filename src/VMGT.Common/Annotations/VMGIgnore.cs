using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common.Annotations
{
    /// <summary>
    /// Standart attribute usage: { class, property }. 
    /// May be applied to namespaces in declarative way through comments.
    /// See documentation for more details
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class VMGIgnore : VMGAttributeBase
    {
        public VMGIgnore(string alias)
            :base((int)Enums.AttributeExecutionPriority.High, Enums.ReservedCommands.Ignore.ToString().ToLower())
        {
        }

        public VMGIgnore()
        {

        }
    }
}
