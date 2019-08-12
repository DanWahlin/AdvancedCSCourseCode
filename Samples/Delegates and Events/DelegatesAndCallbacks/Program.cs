using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.DelegatesAndCallbacks
{
    class Program
    {
        static void Main()
        {
            ReportPrinter rp = new ReportPrinter();

            rp.PrintNextReport(new PrintInfoCallBack(Program.GetPrintInfo), "First Report");

            Console.WriteLine("");

            rp.PrintNextReport(new PrintInfoCallBack(Program.GetPrintInfo), "Second Report");
            Console.ReadLine();
        }

        static void GetPrintInfo(PrintStatus status, object state)
        {
            Console.WriteLine("{0} Print Status = {1}", state.ToString(), status);
        }
    }
}
