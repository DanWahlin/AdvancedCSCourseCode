using System;
using System.Diagnostics;

namespace DebuggingAndTracing.ProcessDemo
{
    class ViewingProcesses
    {
        static void Main()
        {
            //Start a process
            Process notepad = Process.Start("notepad");
            int id = notepad.Id;

            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                Console.WriteLine("Process: " + p.ProcessName);
                try
                {
                    Console.WriteLine("# Modules: " + p.Modules.Count.ToString());
                    foreach (ProcessModule m in p.Modules)
                    {
                        Console.WriteLine("\t\tModule: " + m.ModuleName);
                        Console.WriteLine("\t\tModule Memory: " + m.ModuleMemorySize.ToString());
                    }
                }
                catch (System.ComponentModel.Win32Exception exp)
                {
                    Console.WriteLine("Unable to access modules");
                }
                catch { }
                if (Process.GetCurrentProcess().ProcessName == p.ProcessName)
                {
                    Console.WriteLine("Current running process found: " + p.ProcessName);
                }

            }

            Console.WriteLine("Pausing 2 seconds....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Attempting to kill notepad process.");
            if (!notepad.HasExited) notepad.Kill();
            Console.Read();
        }
    }
}
