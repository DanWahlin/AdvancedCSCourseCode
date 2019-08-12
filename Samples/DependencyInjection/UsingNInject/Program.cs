using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

//Download Ninject from http://ninject.org

namespace UsingNInject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create kernel which creates mapping module called CarModule
            IKernel kernel = new StandardKernel(new CarModule());
            var c = kernel.Get<Car>();
            c.Start();
            Console.ReadLine();
        }
    }

    //Module used to map IEngine to V8Engine
    public class CarModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEngine>().To<V8Engine>();
        }
    }

    public class Car
    {
        //Property Injection
        [Inject]
        public IEngine Engine { get; set; }

        public bool Start()
        {
            if (Engine != null) return Engine.Start();
            else return false;
        }
    }

    public interface IEngine
    {
        bool Start();
        bool Stop();
    }

    public class V8Engine : IEngine
    {

        public bool Start()
        {
            Console.WriteLine("Started Engine!");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Stopped Engine!");
            return true;
        }
    }


}
