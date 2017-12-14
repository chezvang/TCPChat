using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ClientSubscriber : IClient
    {
        public List<IClient> clientSub = new List<IClient>();

        public void AddClient(IClient clientSub)
        {

        }
    }
}
