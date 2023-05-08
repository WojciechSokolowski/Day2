using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08SipleFileExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileExplorer fileExplorer = new FileExplorer();
            fileExplorer.Start();



            Console.ReadKey();
        }
    }
}
