using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    abstract class Observer
    {
        private List<IClient> clientObserver = new List<IClient>();
        private string ObserverName;

        ClientSubscriber clientSubscriber = new ClientSubscriber();

        public Observer(string name)
        {
            this.ObserverName = name;
        }

        public void AddObserver(IClient newClient)
        {
            clientObserver.Add(newClient);
        }

        public void RemoveObserver(IClient removeClient)
        {
            clientObserver.Remove(removeClient);
        }

        public void Alert()
        {
            foreach (IClient client in clientObserver)
            {
                clientSubscriber.Update(this);
            }
        }

    }
}
