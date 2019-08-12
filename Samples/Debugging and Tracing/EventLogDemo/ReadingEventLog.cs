using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DebuggingAndTracing.EventLogDemo
{
    class ReadingEventLog
    {
        static void Main()
        {
            EventLog log = new EventLog();
            log.Log = "Application";
            log.MachineName = ".";
            if (log.Entries != null && log.Entries.Count > 0)
            {
                Console.WriteLine("Source: " + log.Entries[0].Source + " " +
                    "Message: " + log.Entries[0].Message);
            }

            EventLog log2 = new EventLog();
            log2.Log = "System";
            log2.MachineName = ".";
            if (log2.Entries != null && log2.Entries.Count > 0)
            {
                Console.WriteLine("Source: " + log2.Entries[0].Source + " " +
                    "Message: " + log2.Entries[0].Message);
            }
            Console.Read();
        }
    }
}
