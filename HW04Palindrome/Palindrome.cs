using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW04Palindrome
{
    internal class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            string CleanedInput = CleanImput(word);
            string ReversedCleanedImput = ReverseInput(CleanedInput);
            return string.Equals(CleanedInput, ReversedCleanedImput);
        }

        private string ReverseInput(string word)
        {       
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
           
            return new string(charArray);
        }

        private string CleanImput(string word)
        {
            string cleanedInput = word.ToLower();
            cleanedInput = Regex.Replace(cleanedInput, @"\W", "");

            return cleanedInput;
        }

    }
}
