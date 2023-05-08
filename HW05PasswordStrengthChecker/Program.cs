using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05PasswordStrengthChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write password: ");
            string password = Console.ReadLine();
            PasswordStrengthChecker checker = new PasswordStrengthChecker();
            int points = checker.CalculatePasswordStrength(password);
            Console.WriteLine($"Password strength is {points}");
            checker.PasswordSuggestions(password);

            Console.ReadKey();
        }
    }
}
