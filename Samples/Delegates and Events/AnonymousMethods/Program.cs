using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5.AnonymousMethods
{
    class Program
    {
        static void Main()
        {
            ReportPrinter rp = new ReportPrinter();
            PrintInfoCallBack cb = new PrintInfoCallBack(Program.GetPrintInfo1);
            cb += new PrintInfoCallBack(Program.BackUpPrintInfo);

            //Define anonymous method in place of ThreadStart delegate
            System.Threading.Thread t = new System.Threading.Thread(delegate()
            {
                rp.PrintNextReport(cb, "First Report");
            });
            t.Start();

            //Define anonymous method in place of ThreadStart delegate
            System.Threading.Thread t2 = new System.Threading.Thread(delegate()
            {
                rp.PrintNextReport(cb, "Second Report");
            });
            t2.Start();

            Console.ReadLine();
        }

        static void GetPrintInfo1(PrintStatus status, object state)
        {
            Console.WriteLine("{0} PrintStatus: {1}", state.ToString(), status);
        }

        static void BackUpPrintInfo(PrintStatus status, object state)
        {
            Console.WriteLine("Backup job: {0} PrintStatus: {1}", state.ToString(), status);
        }
    }
}
