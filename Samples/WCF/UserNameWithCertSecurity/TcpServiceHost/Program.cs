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
            Type t = typeof(WcfServiceLibrary.CalcService);
            using (ServiceHost host = new ServiceHost(t))
            {
                host.Open();
                Console.WriteLine("<Enter> to stop host");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
