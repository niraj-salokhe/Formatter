using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Library
{
    public class XMLFileHandler : FileHandler
    { 
        public override void Read(string src)
        {
            src = @"" + src;
            fileContent = XDocument.Load(@""+src).ToString();
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
