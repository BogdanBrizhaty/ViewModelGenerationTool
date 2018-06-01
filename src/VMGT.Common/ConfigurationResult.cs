using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Common
{
    public class ConfigurationResult
    {
        public bool Success { get; }
        public string Msg { get; }

        private ConfigurationResult()
        {

        }
        protected internal ConfigurationResult(bool success, string msg, string details = null)
        {
            Success = success;
            Msg = $"{msg}{(details == null ? String.Empty : Environment.NewLine + details)}";
        }
    }

    public sealed class SuccessConfigurationResult : ConfigurationResult
    {
        internal SuccessConfigurationResult(string cmd, Type type)
            : base(true, $"Configuration succeeded. Cmd: {cmd}. Type: {type.FullName}")
        {
        }
    }

    public sealed class FailureConfigurationResult : ConfigurationResult
    {
        internal FailureConfigurationResult(string cmd, Type type, string details = null)
            : base(false, $"Configuration faled. Cmd: {cmd}. Type: {type.FullName}", details)
        {
        }
    }
}
