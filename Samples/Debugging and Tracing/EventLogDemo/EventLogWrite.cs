using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DebuggingAndTracing.EventLogDemo
{
    class EventLogWrite
    {
        static void Main()
        {
            //  NOTE:  ASP.NET applications may not have access to create event sources depending
            //  on the security setup.  See the following articles for security issues with ASP.NET:
            //  http://support.microsoft.com/kb/329291
            //  http://msdn2.microsoft.com/en-us/library/ms998320.aspx#paght000015_eventlogaccess
            string sourceName = "DebuggingAndTracingDemo";
            string logName = "CoreProgramming";
            EventLog log = new EventLog();
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, logName);
            }
            log.Source = sourceName;
            log.Log = logName;
            log.WriteEntry("Test: writing to the event log.", EventLogEntryType.Information);

            if (log.Entries != null && log.Entries.Count > 0)
            {
                Console.WriteLine("Source: " + log.Entries[0].Source + " " +
                    "Message: " + log.Entries[0].Message);
            }

            EventLog.Delete(logName);
            Console.WriteLine("Log deleted....");
            Console.Read();
        }
    }
}
