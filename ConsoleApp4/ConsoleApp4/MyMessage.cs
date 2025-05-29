using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MyMessage
    {
        public string MessageType { get; set; }
        public string Message { get; set; }

        public MyMessage(string type, string message)
        {
            MessageType = type;
            Message = message;
        }
    }
}
