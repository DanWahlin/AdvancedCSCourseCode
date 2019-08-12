using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    public enum PrintStatus
    {
        GeneratingReport,
        GeneratedReport,
        PrintingReport,
        PrintingComplete,
        Error
    }

    //Define delegate
    public delegate void PrintInfoCallBack(PrintStatus status, object state);

    public class ReportPrinter
    {
        public void PrintNextReport(PrintInfoCallBack CallBack, object state)
        {
            //Send data back to callback methods identified in CallBack delegate parameter above
            CallBack(PrintStatus.GeneratingReport, state);
            CallBack(PrintStatus.GeneratedReport, state);
            CallBack(PrintStatus.PrintingReport, state);
            CallBack(PrintStatus.PrintingComplete, state);
        }
    }
}
