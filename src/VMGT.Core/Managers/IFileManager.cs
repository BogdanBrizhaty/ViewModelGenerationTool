using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMGT.Core.Managers
{
    internal interface IFileManager<TContentType>
    {
        Stream ReadStream(string filePath);
        TContentType GetContent(string filePath, params object[] customParameters);
        void Append(string filePath, TContentType content, params object[] customParameters);
        void Write(string filePath, TContentType content, params object[] customParameters);
    }
}
