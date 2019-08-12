using System;

namespace UsingUnity
{
    public class InkJetPrinter : IPrinter
    {
        public bool Print()
        {
            Console.WriteLine("Printered on InkJet Printer!");
            return true;
        }
    }
}