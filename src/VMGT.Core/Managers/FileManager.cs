using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Core.Managers
{
    public class TextFileManager : FileManagerBase<string>
    {
        private readonly Encoding _defaultEncoding = Encoding.UTF8;

        public TextFileManager(Encoding defaultEncoding)
        {
            if (defaultEncoding == null)
                throw new ArgumentNullException(nameof(defaultEncoding));

            _defaultEncoding = defaultEncoding;
        }

        protected override void AppendToFile(string fPath, string content, params object[] customParameters)
        {
            var encoding = GetEncoding(customParameters) ?? _defaultEncoding;
            
            using (var writer = new StreamWriter(fPath, true, encoding))
            {
                writer.Write(content);
                writer.Close();
            }
        }

        protected override string GetContentFrom(string fPath, params object[] customParameters)
        {
            var encoding = GetEncoding(customParameters) ?? _defaultEncoding;
            return File.ReadAllText(fPath, encoding);
        }

        protected override void WriteToFile(string fPath, string content, params object[] customParameters)
        {
            var encoding = GetEncoding(customParameters) ?? _defaultEncoding;

            using (var writer = new StreamWriter(fPath, false, encoding))
            {
                writer.Write(content);
                writer.Close();
            }
        }
        
        private Encoding GetEncoding(params object[] parameters)
        {
            return parameters.FirstOrDefault(cp => cp.GetType() == typeof(Encoding)) as Encoding;
        }
    }
}
