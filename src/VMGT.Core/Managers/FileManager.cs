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
        public Encoding DefaultEncoding { get; }

        #region Constructors
        public TextFileManager()
        {

        }

        public TextFileManager(Encoding defaultEncoding)
        {
            if (defaultEncoding == null)
                throw new ArgumentNullException(nameof(defaultEncoding));

            DefaultEncoding = defaultEncoding;
        }
        #endregion

        protected override void AppendToFile(string fPath, string content, params object[] customParameters)
        {
            WriteToFile(fPath, content, true, GetEncoding(customParameters));
        }

        protected override string GetContentFrom(string fPath, params object[] customParameters)
        {
            return File.ReadAllText(fPath, GetEncoding(customParameters));
        }

        protected override void WriteToFile(string fPath, string content, params object[] customParameters)
        {
            WriteToFile(fPath, content, false, GetEncoding(customParameters));
        }

        protected Encoding GetEncoding(params object[] parameters)
        {
            return (parameters.FirstOrDefault(cp => cp.GetType() == typeof(Encoding)) as Encoding) ?? DefaultEncoding;
        }

        private void WriteToFile(string fPath, string content, bool append, Encoding encoding)
        {
            using (var writer = new StreamWriter(fPath, append, encoding))
            {
                writer.Write(content);
                writer.Close();
            }
        }
    }
}
