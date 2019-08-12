using System;
using System.Diagnostics;

namespace DebuggingAndTracing.PerformanceMonitors
{
    class PerformanceCounterDemo
    {
        static void Main()
        {
            if (PerformanceCounterCategory.Exists("SalesDistribution"))
            {
                PerformanceCounterCategory.Delete("SalesDistribution");
            }
            CounterCreationDataCollection coll = new CounterCreationDataCollection();
            CounterCreationData data = new CounterCreationData();
            data.CounterName = "RequestsPerSec";
            data.CounterType = PerformanceCounterType.NumberOfItems32;
            data.CounterHelp = "Requests received per second";
            coll.Add(data);

            PerformanceCounterCategory.Create("SalesDistribution", "Automated Sales Distribution System",
                PerformanceCounterCategoryType.SingleInstance, coll);
            PerformanceCounter counter = new PerformanceCounter("SalesDistribution", "RequestsPerSec", false);
            int x = 1;
            while (x <= 50)
            {
                Console.WriteLine("RequestsPerSec = {0}", counter.RawValue);
                counter.Increment();
                System.Threading.Thread.Sleep(250);
                x = (x + 1);
            }
            counter.Close();
            Console.Read();
        }
    }
}
