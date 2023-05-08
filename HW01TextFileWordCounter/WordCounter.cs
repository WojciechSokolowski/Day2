using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01TextFileWordCounter
{
    internal class WordCounter
    {
        private List<string> GetFiles(string folder)
        {

            List<string> files = new List<string>(Directory.GetFiles(folder, "*.txt"));

            return files;

        }
        
        private int ReadNumberOfWords(string file)
        { 
        string WholeFile = File.ReadAllText(file);

            string[] WordsInFile = WholeFile.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            return WordsInFile.Length;
        }

        public void CountAllFiles(string folder)
        {
            List<string> files = GetFiles(folder);
            
            int GrandTotalWords = 0;

            foreach (string file in files) {
                int count = ReadNumberOfWords(file);
                Console.WriteLine($"File: {Path.GetFileName(file)} \t Count: {count}");
                GrandTotalWords += count;
            }
            Console.WriteLine($"Grand Total Count of Words {GrandTotalWords}");
        }


    }
}
