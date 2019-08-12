using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;

//Download Unity from http://msdn.microsoft.com/en-us/library/ff663144.aspx

namespace UsingUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPrinter, LaserPrinter>();
            var c = container.Resolve<Report>().Print();
            Console.ReadLine();
        }
    }
}
