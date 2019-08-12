using System;
using System.Diagnostics;

namespace DebuggingAndTracing.Tracing
{
    class UsingTraceSwitches
    {
        private static TraceSource appSource = new TraceSource("TraceSwitchSource");
        static TraceSwitch s = new TraceSwitch("AppTraceSwitch","Application switch in App.config");
        static void Main()
        {
            PerformAction();
            Console.Read();
        }

        static void PerformAction()
        {
            //Write using trace source
            appSource.TraceEvent(TraceEventType.Warning, 2,"Warning message.");

            //Write using trace listeners
            Trace.WriteLineIf(s.TraceWarning, "Warning: In PerformAction()");
            Trace.WriteLineIf(s.TraceInfo, "Info: In PerformAction()");
            Trace.WriteLineIf(s.TraceVerbose, "Verbose: Entered PerformAction()");
            try
            {
                //Demonstrate tracing error
                throw new ApplicationException("Error in PerformAction()");
            }
            catch (Exception exp)
            {
                Trace.WriteLineIf(s.TraceError || s.TraceVerbose, "Error: Error in PerformAction - " + exp.Message);
            }
        }
    }
}
