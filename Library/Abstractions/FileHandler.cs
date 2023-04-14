using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class FileHandler
    {
        protected string filePath;
        protected string fileContent;

        public FileHandler()
        {

        }

        public virtual void Read(string src)
        {
            fileContent = File.ReadAllText(@"" + src);
        }

        public virtual void Write(string content, string dst)
        {
            File.WriteAllText(@"" + dst, content);
        }

        public virtual bool Validate()
        {
            return true;
        }

        public string GetContent() { return fileContent; }
    }
}
