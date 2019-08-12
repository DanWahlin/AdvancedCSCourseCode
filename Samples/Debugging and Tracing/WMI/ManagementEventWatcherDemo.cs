using System;
using System.Diagnostics;
using System.Management;

namespace DebuggingAndTracing.WMI
{
    /// <summary>
    /// Run this class and then start notepad.  When the instance creation event fires
    /// it will note that notepad is running and then kill the process.
    /// </summary>
    class ManagementEventWatcherDemo
    {
        static void Main()
        {
            //Create query that represents event that needs to be watched for
            WqlEventQuery query = new WqlEventQuery("__InstanceCreationEvent", 
             new TimeSpan(0, 0, 1), "TargetInstance ISA \"Win32_Process\"");

            ManagementEventWatcher watcher = new ManagementEventWatcher(query);
            watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcher.Start();
            Console.WriteLine("Listening for Instance Creation events.");
            Console.Read();
        }

        static void watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            ManagementBaseObject mObj = (ManagementBaseObject)e.NewEvent["TargetInstance"];
            string instanceName = mObj["Name"].ToString();
            Console.WriteLine("Instance Creation event raised: " + instanceName);
            Console.WriteLine("Writing out event properties...");
            foreach (PropertyData pd in e.NewEvent.Properties)
            {
                Console.WriteLine("\t\t{0} : {1}", pd.Name, pd.Value);
            }

            Console.WriteLine("Writing out ManagementBaseObject Properties");
            foreach (PropertyData pd in mObj.Properties)
            {
                Console.WriteLine("\t\t{0} : {1}", pd.Name, pd.Value);
            }
            if (instanceName.ToLower().Contains("notepad"))
            {
                Console.WriteLine("Found running notepad instance and am killing it.");
                System.Threading.Thread.Sleep(1000);
                Process[] processes = Process.GetProcessesByName("notepad");
                foreach (Process p in processes)
                {
                    p.Kill();
                }
                Console.WriteLine("Killed notepad process.");
            }
        }

    }
}
