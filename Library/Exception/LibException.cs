using Library.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Exception
{
    public class LibException : SystemException
    {

        public LibException() : base() { }

        public LibException(string message) : base(message) { 
            
        }
    }
}
