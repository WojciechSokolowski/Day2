using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07MorseCodeTransator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MorseCodeTranslator translator = new MorseCodeTranslator();
            Console.WriteLine("Enter a sring in standard letters or in morse code");
            string input = Console.ReadLine();
            
            if (translator.IsMorseCode(input))
            {
                string standardText = translator.MorseCodeToText(input);
                Console.WriteLine($"text translates to: {standardText}");
            }
            else
            {
                string standardText = translator.TextToMorseCode(input);
                Console.WriteLine($"text translates to: {standardText}");
            }

            Console.ReadKey();  
        }
    }
}
