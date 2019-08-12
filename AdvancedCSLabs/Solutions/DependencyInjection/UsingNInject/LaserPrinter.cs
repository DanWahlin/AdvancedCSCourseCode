using System;

namespace UsingNInject
{
    public class LaserPrinter : IPrinter
    {
        public bool Print()
        {
            Console.WriteLine("Printered on Laser Printer!");
            return true;
        }
    }
}