using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW06HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "codecool", "hangman", "game","computer","developer" };
            Hangman hangman = new Hangman(words);
            hangman.Play();

            Console.ReadKey();
        }
    }
}
