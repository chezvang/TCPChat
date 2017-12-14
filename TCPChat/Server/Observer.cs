using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Observer : IObserver <string>
    {
        public string ObserverName { get; private set; }

        public Observer(string name)
        {
            this.ObserverName = name;
        }

        public AddObserver()
        {

        }

        public void Alert()
        {
            Console.WriteLine(ObserverName + "has entered the chatroom");
        }


        public void OnNext(string value)
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
