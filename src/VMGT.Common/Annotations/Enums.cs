using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common
{
    public class Enums
    {
        /// <summary>
        /// Priority when two or more types are allowed
        /// </summary>
        public enum AttributeExecutionPriority
        {
            //Ignore execution
            Ignore = 0,
            Low = 5,
            Intermediate = 10,
            High = 15,
            Default = 5
        }

        /// <summary>
        /// Reserved command names pre-defined in VMG Tool
        /// </summary>
        internal enum ReservedCommands
        {
            Ignore,
            Include,
            Inherit,
            InheritFromViewModel,
            PropertyOptions
        }

        /// <summary>
        /// Defines one of the following types to generate: { Auto, WithBackingField, Observable }
        /// </summary>
        public enum PropertyType
        {
            /// <summary>
            /// Regular auto property
            /// </summary>
            Auto,
            /// <summary>
            /// Property with backing field in it
            /// </summary>
            WithBackingField,
            /// <summary>
            /// Observable property that fires PropertyChanged event notification of INotifyPropertyChanged
            /// </summary>
            Observable
        }
    }
}
