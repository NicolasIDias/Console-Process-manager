using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWIthProcess
{
    class DumpProcessInfo
    {
        public static void ProcessInfo() 
        {
            try
            {
                Console.WriteLine("Write the name of the process");
                string procName = Console.ReadLine();



                Process[] process = Process.GetProcessesByName(procName);

                if (process.Length == 0)
                {
                    Console.WriteLine("Process: " + procName + " not found");
                }

                else
                {
                    for (int i = 0; i < process.Length; i++)
                    {
                        Console.WriteLine("_______________________________________________________________________");
                        Console.WriteLine("\nProcess name: " + process[i].ProcessName);
                        Console.WriteLine("PID: " + process[i].Id);
                        Console.WriteLine("Status: " + process[i].Responding);
                        Console.WriteLine("Total processor time: " + process[i].TotalProcessorTime);
                        Console.WriteLine("Private memory size [64]: " + process[i].PrivateMemorySize64 + " bytes");
                        Console.WriteLine("Paged memory size [64]: " + process[i].PagedMemorySize64 + " bytes");
                        Console.WriteLine("_______________________________________________________________________");
                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine("An error war ocurred:\n");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
