using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01TextFileWordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordCounter wordCounter = new WordCounter();

            wordCounter.CountAllFiles(@"c:\data");

            Console.ReadKey();
        }
    }
}
