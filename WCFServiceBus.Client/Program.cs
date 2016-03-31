using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceBus.Services;

namespace WCFServiceBus.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name or '1' to exit.");
            var name = Console.ReadLine();

            while (name != "1")
            {
                HelloClient proxy = new HelloClient();
                var message = proxy.SayHello(name);

                Console.WriteLine(message);

                proxy.Close();

                Console.WriteLine("Enter a name or '1' to exit.");
                name = Console.ReadLine();
            }
        }
    }
}
