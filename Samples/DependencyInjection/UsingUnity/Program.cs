using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;

namespace UsingUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IEngine, V8Engine>();
            var c = container.Resolve<Car>().Start();
            Console.ReadLine();
        }
    }

    public class Car
    {
        IEngine _Engine;

        //Constructor injection
        public Car(IEngine engine)
        {
            _Engine = engine;
        }

        public bool Start()
        {
            if (_Engine != null) return _Engine.Start();
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
