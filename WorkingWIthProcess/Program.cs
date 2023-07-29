using WorkingWIthProcess;

namespace WorkingWithProcess { 
    class Program
    {   
        static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Write [1] to show all the current running processes");
                Console.WriteLine("Type [2] to dump a process info");
                Console.WriteLine("Type [3] to kill a process");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        DumpProcesses.Dump();
                        break;
                    case 2:
                        DumpProcessInfo.ProcessInfo();
                        break;
                    case 3:
                        KillProcess.kill();
                        break;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine("An error war ocurred:\n");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}