using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWIthProcess
{
    class KillProcess
    {
        public static void kill()
        {
            try
            {
                Console.WriteLine("Write the name of the process to kill");
                string processName = Console.ReadLine();

                Process[] process = Process.GetProcessesByName(processName);
                foreach (Process process2 in process)
                {
                    process2.Kill();
                }
            }catch (Exception ex) {
                Console.WriteLine("An error war ocurred:\n");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
