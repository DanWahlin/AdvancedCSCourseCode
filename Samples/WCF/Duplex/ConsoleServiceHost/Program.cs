using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsoleServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address, Binding, Contract
            //ServiceHost
            Type serviceType = typeof(WcfServiceLibrary1.Service1);
            ServiceHost host = new ServiceHost(serviceType);
            using (host)
            {              
                host.Open();
                Console.WriteLine("Listening on port 9090");
                Console.Read();
            } //Dispose is called which closes host

        }
    }
}
