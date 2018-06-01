using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common.Annotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class VMGInclude : VMGAttributeBase
    {
        public string NamePrefix { get; set; }
        public string NamePostfix { get; set; } = "ViewModel";
        public string OutputName => NamePrefix + NamePostfix;
        //public bool InheritFrom

        public VMGInclude()
            : base((int)Enums.AttributeExecutionPriority.Default, Enums.ReservedCommands.Include)
        {
        }
    }
}
