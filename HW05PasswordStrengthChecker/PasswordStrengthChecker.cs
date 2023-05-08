using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05PasswordStrengthChecker
{
    internal class PasswordStrengthChecker
    {
        public int CalculatePasswordStrength(string password)
        {
            int lengthScore = CalculateLengthScore(password);
            int specialCharScore = CalculateSpecialCharScore(password);
            int digitScore = CalculateDigitSore(password);
            int uppercaseScore = CalculateUppercaseScore(password);
            int lowercaseScore = CalculateLowercaseScore(password);

            return lengthScore + specialCharScore + digitScore + uppercaseScore + lowercaseScore;
        }

        private int CalculateLengthScore(string password)
        {
            int length = password.Length;
            return length * 5;
        }
        private int CalculateSpecialCharScore(string password)
        {
            int SpecialCharCount = 0;
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                    SpecialCharCount++;
            }
            return SpecialCharCount * 8;

        }
        private int CalculateDigitSore(string password)
        {
            int digits = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    digits++;
            }
            return digits * 2;
        }

        private int CalculateUppercaseScore(string password)
        {
            int uppercaseCount = 0;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    uppercaseCount++;
            }
            return uppercaseCount * 2;
        }
        private int CalculateLowercaseScore(string password)
        {
            int lowercaseCount = 0;
            foreach (char c in password)
            {
                if (char.IsLower(c))
                    lowercaseCount++;
            }
            return lowercaseCount;

        }

        public void PasswordSuggestions(string password)
        {
            if (password.Length < 8)
                Console.WriteLine("Password should be at least 8 haracters long.");
            if (CalculateSpecialCharScore(password) == 0)
                Console.WriteLine("Add special characters.");
            if (CalculateDigitSore(password) == 0)
                Console.WriteLine("Add digits.");
            if (CalculateUppercaseScore(password) == 0)
                Console.WriteLine("Add uppercase characters.");
            if (CalculateLowercaseScore(password) == 0)
                Console.WriteLine("Add lowercase characters.");


        }



    }
}
