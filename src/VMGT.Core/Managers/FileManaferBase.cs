using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Core.Managers
{
    public abstract class FileManagerBase<TContent> : IFileManager<TContent>
    {
        #region IFilterManager implementation

        public void Append(string filePath, TContent content, params object[] customParameters)
        {
            CheckFileExistance(filePath);
            AppendToFile(filePath, content, customParameters);
        }
        public TContent GetContent(string filePath, params object[] customParameters)
        {
            CheckFileExistance(filePath);
            return GetContentFrom(filePath, customParameters);
        }
        public void Write(string filePath, TContent content, params object[] customParameters)
        {
            CheckFileExistance(filePath);
            WriteToFile(filePath, content, customParameters);
        }
        public virtual Stream ReadStream(string filePath)
        {
            CheckFileExistance(filePath);
            return File.OpenRead(filePath);
        }
        #endregion

        #region Abstract members related to IFIlterManager implementation methods

        protected abstract void AppendToFile(string fPath, TContent content, params object[] customParameters);
        protected abstract void WriteToFile(string fPath, TContent content, params object[] customParameters);
        protected abstract TContent GetContentFrom(string fPath, params object[] customParameters);

        #endregion

        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        private void CheckFileExistance(string filePath)
        {
            if (!FileExists(filePath))
                throw new FileNotFoundException("File was not found.", filePath);
        }
    }
}
