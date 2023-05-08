using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10ShortURLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            URLShortener shortener = new URLShortener();
            
            while (true)
            {
                Console.WriteLine("Enter '1' to shorten an URL, '2' to expand a short code or '3' to exit");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Enter URL");
                    string url = Console.ReadLine();
                    string shortUrl = shortener.ShortenURL(url);
                    Console.WriteLine($"Short URL: {shortUrl}");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter short URL to expand");
                    string url = Console.ReadLine();
                    string longUrl = shortener.ExpandURL(url);
                    Console.WriteLine($"Expanded URL: {longUrl}");
                }
                else if (input == "3")
                    break;
                else
                    Console.WriteLine("Wrong imput, try again.");
            }
        }
    }
}
