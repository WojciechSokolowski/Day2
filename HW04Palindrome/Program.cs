using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word or phrase: ");
            string word = Console.ReadLine();

            Palindrome palindrome = new Palindrome();
            bool IsPalindrome = palindrome.IsPalindrome(word);

            if (IsPalindrome) {
                Console.WriteLine($"{word} is a palindrome");
            }
            else
                Console.WriteLine($"{word} is not a palindrome");

            Console.ReadKey();
        }
       
    }
}
