using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utils
{
    public static class Helper
    {
        public static FileTypeEnum GetFileType(string src)
        {
            if (Enum.TryParse<FileTypeEnum>(src.Substring((src.LastIndexOf('.')+1), src.Length - (src.LastIndexOf('.')+1)), out FileTypeEnum fileType))
            {
                return fileType;
            }

            return FileTypeEnum.None;
        }
    }

}
