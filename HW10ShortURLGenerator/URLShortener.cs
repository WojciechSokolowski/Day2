using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10ShortURLGenerator
{
    internal class URLShortener
    {
        private Dictionary<string, string> urlMapping;

        public URLShortener()
        {
            urlMapping = new Dictionary<string, string>();
        }

        public string ShortenURL(string url)
        {
            string shortUrl = GenerateShortURL();
            urlMapping[shortUrl]=url;
            return shortUrl;
        }
        public string ExpandURL(string shortUrl)
        {
            if (urlMapping.ContainsKey(shortUrl))
            {
                return urlMapping[shortUrl];
            }
            else
            {
                return "Short url not found";
            }
        }

        private string GenerateShortURL()
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] shortURLChars = new char[6];
            for (int i = 0; i < 6; i++)
            {
                shortURLChars[i] = characters[random.Next(characters.Length)];
            }
            return new string(shortURLChars);
        }


    }
}
