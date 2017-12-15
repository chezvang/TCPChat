using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ClientSubscriber
    {
        private string clientName;

        public void Update(Observer client)
        {
            Console.WriteLine(clientName + "has entered the chatroom.");
        }

    }
}
