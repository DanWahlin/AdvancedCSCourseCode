using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

//Download Ninject from http://ninject.org

namespace UsingNInject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create kernel which creates mapping module called CarModule
            IKernel kernel = new StandardKernel();
            kernel.Bind<IPrinter>().To<LaserPrinter>();
            var report = kernel.Get<Report>();
            report.Print();
            Console.ReadLine();
        }
    }
}
