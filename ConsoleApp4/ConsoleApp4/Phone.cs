using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Phone
    {
        public Phone(MessageManager manager)
        {
            manager.NewMessage += ReceiveSns;
        }

        private void ReceiveSns(MyMessage msg)
        {
            if (msg.MessageType == "sms")
            {
                Console.WriteLine($"Phone received: {msg.Message}");
            }
        }
    }
}
