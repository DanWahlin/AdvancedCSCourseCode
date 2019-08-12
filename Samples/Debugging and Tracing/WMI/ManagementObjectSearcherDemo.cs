using System;
using System.Management;
using System.Diagnostics;

namespace DebuggingAndTracing.WMI
{
    /// <summary>
    /// Shows how to query the OS using WMI queries.  If notepad is running it will be found and killed.
    /// </summary>
    class ManagementObjectSearcherDemo
    {
        static void Main()
        {
            //Show all windows services
            Console.WriteLine("Getting all windows services...");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("\\root\\CIMV2",
                "SELECT Name,State FROM Win32_Service");
            foreach (ManagementObject service in searcher.Get())
            {
                Console.WriteLine("\tName: {0}   Status: {1}", service["Name"].ToString(),
                    service["State"].ToString());
            }

            Console.WriteLine("Getting processes...");
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("\\root\\CIMV2",
                "SELECT Name,ProcessID FROM Win32_Process");
            foreach (ManagementObject service in searcher2.Get())
            {
                Console.WriteLine("\tProcess Name: {0}   ProcessID: {1}", service["Name"].ToString(),
                    service["ProcessID"].ToString());
                if (service["Name"].ToString().ToLower().Contains("notepad"))
                {
                    Console.WriteLine("Found notepad and killing process...");
                    Process p = Process.GetProcessById(Int32.Parse(service["ProcessID"].ToString()));
                    p.Kill();
                }
            }

            Console.WriteLine("Getting disk information...");
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("\\root\\CIMV2",
                "SELECT Size, FreeSpace, Name, FileSystem FROM Win32_LogicalDisk WHERE DriveType = 3");
            foreach (ManagementObject disk in searcher3.Get())
            {
                try
                {
                    Console.WriteLine("Disk: {0}  Size:{1}  Free Space:{2}", disk["Name"].ToString(),
                        disk["Size"].ToString(), disk["FreeSpace"].ToString());
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Error retrieving disk information for {0} - {1}",disk["Name"].ToString(),
                        exp.Message);
                }
            }

            Console.WriteLine("Getting mother board information...");
            //Can query remote machine (with access rights):  \\\\192.168.1.100\\root\\CIMV2
            ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("\\root\\CIMV2",
                "SELECT Name,InstallDate,PrimaryBusType,Status FROM Win32_MotherboardDevice");
            foreach (ManagementObject service in searcher4.Get())
            {
                Console.WriteLine("\tName: {0}   Primary Bus Type: {1}   Status: {2}", service["Name"].ToString(),
                    service["PrimaryBusType"].ToString(), service["Status"].ToString());
            }

            Console.Read();
        }
    }
}
