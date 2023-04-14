using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utils
{
    internal static class FileMapping
    {
        internal static Dictionary<string, string> handlerMapping = new Dictionary<string, string>()
        {
            {"xml","XMLFileHandler" },
            {"txt","TXTFileHandler" },
            {"json","JSONFileHandler" }
        };

    }
}
