using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace uso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("                           Unreal Screenshot Opener                             ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("");

            if (args.Length >= 2)
            {
                string unrealDirectory = args[0];
                string unrealFiletype = args[1];

                List<string> files = Directory.GetFiles(unrealDirectory, ("*." + unrealFiletype)).OrderBy(f => f).Reverse().ToList();
                string fileToOpen = files[0];
    
                Console.WriteLine("Opening:");
                Console.WriteLine(fileToOpen);
                
                Process startInfo = new Process();
                startInfo.StartInfo.FileName = fileToOpen;
                startInfo.Start();
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("                                     Error                                      ");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Specify Unreal screenshots path AND the filetype of the screenshots");
                Console.WriteLine("WITHOUT the \\ at the end!");
                Console.WriteLine("");
                Console.WriteLine("EXAMPLE: uso.exe \"c:\\projects\\unreal projects\\Saved\\Screenshots\" png");
                Console.ReadKey();
            }
        }
    }
}
