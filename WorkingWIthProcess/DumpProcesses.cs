using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWIthProcess
{
    class DumpProcesses
    {

        public static void Dump()
        {
            Process[] process = Process.GetProcesses();

            for(int i=0;i<process.Length; i++)
            {
                Console.WriteLine("\nProcess name: " + process[i].ProcessName);
            }
        }
    }
}
