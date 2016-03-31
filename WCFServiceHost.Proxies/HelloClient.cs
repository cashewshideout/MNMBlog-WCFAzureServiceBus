using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServiceBus.Contracts;

namespace WCFServiceBus.Services
{
    public class HelloClient : ClientBase<IHelloService>, IHelloService
    {
        public string SayHello(string name)
        {
            return Channel.SayHello(name);
        }
    }
}
