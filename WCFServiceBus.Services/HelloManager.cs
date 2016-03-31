using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceBus.Contracts;

namespace WCFServiceHost.Proxies
{
    public class HelloManager : IHelloService
    {
        public string SayHello(string name)
        {
            return "Hello, " + name;
        }
    }
}
