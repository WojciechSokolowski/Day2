using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07MorseCodeTransator
{
    internal class MorseCodeTranslator
    {
        private Dictionary<char, string> morseCodeMap;
        private Dictionary<string, char> reverseMorseCodeMap;

        public MorseCodeTranslator()
        {
            initializeMorseCodeMap();
            initializeMorsceCodeReverseMap();
        }

        private void initializeMorseCodeMap()
        {
            morseCodeMap = new Dictionary<char, string>
        {
            { 'A', ".-" },
            { 'B', "-..." },
            { 'C', "-.-." },
            { 'D', "-.." },
            { 'E', "." },
            { 'F', "..-." },
            { 'G', "--." },
            { 'H', "...." },
            { 'I', ".." },
            { 'J', ".---" },
            { 'K', "-.-" },
            { 'L', ".-.." },
            { 'M', "--" },
            { 'N', "-." },
            { 'O', "---" },
            { 'P', ".--." },
            { 'Q', "--.-" },
            { 'R', ".-." },
            { 'S', "..." },
            { 'T', "-" },
            { 'U', "..-" },
            { 'V', "...-" },
            { 'W', ".--" },
            { 'X', "-..-" },
            { 'Y', "-.--" },
            { 'Z', "--.." },
            { '0', "-----" },
            { '1', ".----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." }
        };
        }

        private void initializeMorsceCodeReverseMap()
        {
            reverseMorseCodeMap = new Dictionary<string, char>();

            foreach (KeyValuePair<char, string> entry in morseCodeMap)
                reverseMorseCodeMap[entry.Value] = entry.Key;
        }

        public string TextToMorseCode(string text)
        {
            string morseCode = "";

            foreach (char c in text.ToUpper()) 
            {
               if(morseCodeMap.ContainsKey(c))
                    morseCode += morseCodeMap[c]+" ";
               else if (c==' ')
                    morseCode += @" / ";
            }
            return morseCode;

        }

        public string MorseCodeToText(string text)
        {
            string[] morseWords = text.Split(new[] {" / "}, StringSplitOptions.RemoveEmptyEntries);
            string standardText = "";
            foreach(string word in morseWords)
            {
                string[] morseLetters = word.Split(' ');
                foreach(string letter in morseLetters)
                {
                    if (reverseMorseCodeMap.ContainsKey(letter))
                        standardText+= reverseMorseCodeMap[letter];
                }
                standardText += " ";
            }
            return standardText.Trim();
        }

        public bool IsMorseCode(string text)
        {
            return (text.Contains('.') || text.Contains('-'));


        }



    }
}
