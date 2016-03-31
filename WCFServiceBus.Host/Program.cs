using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServiceBus.Services;

namespace WCFServiceBus.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HelloManager));
            host.Open();

            Console.WriteLine("Service Started");
            Console.ReadLine();

            host.Close();
        }
    }
}
