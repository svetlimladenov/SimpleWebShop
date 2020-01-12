using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyNetQ;
using SimpleWebShop.Messages;

namespace SimpleWebShop.MS.TestMicroservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bus = RabbitHutch.CreateBus("host=localhost");
            Console.WriteLine("Waiting for messages");
            bus.Subscribe<TestMessage>("subId", (m) =>
            {
                Console.WriteLine($"{m.Name} - {m.Age}");
                File.WriteAllText("log.txt", $"{m.Name} - {m.Age}");
            });
        }
    }
}
