using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C05EXMextManager
{
    internal class TextManager
    {
        public string GetLongestWord(string sentence)
        {
                int BiggestLength = 0;
                string resoult="";
            try
            {
                string[] words = sentence.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);


                foreach (string word in words) { 
                    
                    if (word.Length == 0)
                    {
                        throw new Exception();

                    }

                    if (word.Length > BiggestLength)
                    {
                        BiggestLength = word.Length;
                        resoult = word;
                    }
                
                }

        }
            catch(Exception)  {
                Console.WriteLine("No words");
            
            }
            return resoult;

        }

        public string GetLongWords(string sentence) {

                string report = "";

            try
            {
                string[] words = sentence.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                int[] LengthOfWord = new int[words.Length];


                for (int i=0; i<words.Length;i++)
                {

                    if (words[i].Length == 0)
                    {
                        throw new Exception();

                    }
                    LengthOfWord[i] = words[i].Length;
                }

                int maxValue = LengthOfWord.Max();

                List<string> LongestWords = new List<string>();

                for (int i=0  ; i<words.Length ; i++)
                {
                    if (LengthOfWord[i] == maxValue)
                        LongestWords.Add(words[i]);
                }

                 report = string.Format("The longest words are {0}",
                        string.Join(", ", LongestWords));

            }
            catch (Exception)
            {
                Console.WriteLine("No words");

            }
            return report;



        }


    }



}
