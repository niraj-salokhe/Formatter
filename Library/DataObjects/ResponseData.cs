using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ResponseData
    {   
        public ResponseData() { }

        public StatusCode statusCode { get; set; }

        public string message { get; set; }

        public ResultObject result { get; set; }

    }
}
