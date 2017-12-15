using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        public static Client client;
        TcpListener server;

        Dictionary<int, Client> user = new Dictionary<int, Client>(); //add users to dictionary
        int userID = 0;
        Queue<string> queueMessage = new Queue<string>();

        List<string> observer;

        public Server()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9999);
            server.Start();
        }

        public void Run()
        {
            Task.Run(() => AcceptClient());
            //string message = client.Recieve();
            //Respond(message);
        }

        private void AcceptClient()
        {
            while (true)
            {
                TcpClient clientSocket = default(TcpClient);
                clientSocket = server.AcceptTcpClient();
                Console.WriteLine("Connected");
                NetworkStream stream = clientSocket.GetStream();
                client = new Client(stream, clientSocket);
                AddToDictionary(client);
                Task.Run(() => Recieve());
            }
        }
        private void Send(string body)
        {
            Client temp;
            string message = body;
            while (true)
            {
                foreach (KeyValuePair<int, Client> userID in user)
                {
                    temp = userID.Value;
                    temp.Send(queueMessage.Dequeue());
                }
            }
        }

        public void Recieve()
        {
            while (true)
            {
                string message = client.Recieve(queueMessage);
                Task.Run(() => Send(message));
            }
        }

        public void AddToDictionary(Client client)
        {
            userID++;
            user.Add(userID, client);
        }

        //observer design pattern

        //thread

        //static void MainThread()
        //{
        //    Thread t = new Thread(Print1);

        //    t.Start();

        //    Console.ReadLine();
        //}

        //static void Print1()
        //{
        //    for (int i = 0; i < 1; i++;)
        //    {

        //    }
        //}

        //dependency injection


    }
}
