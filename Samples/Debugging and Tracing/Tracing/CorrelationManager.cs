using System;
using System.Diagnostics;
using System.Threading;

namespace DebuggingAndTracing.Tracing
{
    class CorrelationManager
    {
        static void Main()
        {
            DelimitedListTraceListener listener = new DelimitedListTraceListener("../../Tracing/CorrelationLog.log");
            listener.Delimiter = "|";
            ConsoleTraceListener console = new ConsoleTraceListener();
            listener.TraceOutputOptions |= TraceOptions.LogicalOperationStack;
            console.TraceOutputOptions |= TraceOptions.LogicalOperationStack;
            Trace.Listeners.Clear();
            Trace.Listeners.Add(listener);
            Trace.Listeners.Add(console);
            Trace.CorrelationManager.StartLogicalOperation("Main Method Calls");
            Trace.TraceInformation("Starting processing threads...");
            Thread[] threads = new Thread[2];
            threads[0] = new Thread(new ThreadStart(ProcessOrders));
            threads[1] = new Thread(new ThreadStart(ShipProcessedOrders));
            threads[0].Start();
            threads[1].Start();
            
            //Block until each thread returns
            threads[0].Join();
            threads[1].Join();

            Trace.CorrelationManager.StopLogicalOperation();
            Console.Read();
        }

        static void ProcessOrders()
        {
            Trace.CorrelationManager.StartLogicalOperation("ProcessOrders");
            Trace.TraceInformation("Processing orders");
            Trace.CorrelationManager.StopLogicalOperation();
        }

        static void ShipProcessedOrders()
        {
            Trace.CorrelationManager.StartLogicalOperation("ShipProcessedOrders");
            Trace.TraceInformation("Shipping orders");
            Trace.CorrelationManager.StopLogicalOperation();
        }
    }
}
