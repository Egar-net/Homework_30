using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Mail
    {
        public Mail(MessageManager manager)
        {
            manager.NewMessage += ReceiveMail;
        }

        private void ReceiveMail(MyMessage msg)
        {
            if (msg.MessageType == "email")
            {
                Console.WriteLine($"Mail received: {msg.Message}");
            }
        }
    }
}
