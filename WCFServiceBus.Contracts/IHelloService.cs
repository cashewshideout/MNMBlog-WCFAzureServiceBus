using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceBus.Contracts
{
    public interface IHelloService
    {
        [OperationContract]
        string SayHello(string name);
    }
}
