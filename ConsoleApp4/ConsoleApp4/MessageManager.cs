using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MessageManager
    {
        public event Action<MyMessage> NewMessage;

        public void SendMessage(MyMessage msg)
        {
            NewMessage?.Invoke(msg);
        }
    }
}
