using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EXMextManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog.";
            TextManager textManager = new TextManager();
            string Text = textManager.GetLongestWord(sentence);

            Console.WriteLine(Text);

            string text2 = textManager.GetLongestWord(" ");


            Text = textManager.GetLongWords(sentence);
            Console.WriteLine(Text);

            Text = textManager.GetLongWords(" ");
            Console.WriteLine(Text);

            Console.ReadKey();
        }
    }
}
