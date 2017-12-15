﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("192.168.0.118", 9999); //127.0.0.1

            Parallel.Invoke(() =>
            {
                while (true)
                {
                    client.Send();
                }
            },
            () =>
            {
                while (true)
                {
                    client.Recieve();
                }          
            });

            Console.ReadLine();
        }
    }
}
