using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW06HangmanGame
{
    internal class Hangman
    {
        private string selectedWord;
        private string guessedWord;
        private int attempts;
        private List<char> incorrectGuesess;

        public Hangman(List<string> words)
        {
            Random random = new Random();
            selectedWord = words[random.Next(words.Count)];
            guessedWord = InitializeGuessedWord(selectedWord);
            attempts = 6;
            incorrectGuesess = new List<char>();
        }
        private string InitializeGuessedWord(string word)
        {
            string guessedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    guessedWord += "_";
                }
                else
                {
                    guessedWord += word[i];
                }
            }
            return guessedWord;
        }

        private string UpdateGuessedWord(string word, string guesedWord, char guess)
        {
            char[] UpdatedGuessedWord = guesedWord.ToCharArray();

            for(int i = 0; i < word.Length; i++)
            {
                if (char.ToLower(word[i]) == char.ToLower(guess)) 
                {
                    UpdatedGuessedWord[i] = word[i]; 
                }
            }
            return new string(UpdatedGuessedWord);
        }

        public void Play()
        {
            Console.WriteLine($"Guessed Word: {guessedWord}");
            while (attempts >0 && guessedWord.Contains("_"))
            {
                Console.Write("Guess a letter: ");
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (selectedWord.Contains(guess))
                {
                    guessedWord = UpdateGuessedWord(selectedWord, guessedWord, guess);
                }
                else
                {
                    attempts--;
                    incorrectGuesess.Add(guess);
                }
                Console.WriteLine($"Attempts left: {attempts}");
                Console.WriteLine($"Guessed Word: {guessedWord}");
                Console.WriteLine($"Incorrect Guesses: {string.Join(", ", incorrectGuesess)}");
                draw(attempts);
            }

            if (guessedWord == selectedWord)
                Console.WriteLine("you win");
            else
                Console.WriteLine("you lose");


        }

        private void draw(int attempts)
        {
            switch (attempts)
            {
                case 6:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(@"/");
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(@"/ \");
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine(@" | ");
                    Console.WriteLine(@"/ \");
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine(@"/| ");
                    Console.WriteLine(@"/ \");
                    break;

                case 1:
                    Console.WriteLine();
                    Console.WriteLine(@"/|\");
                    Console.WriteLine(@"/ \");
                    break;

                case 0:
                    Console.WriteLine( " o ");
                    Console.WriteLine(@"/|\");
                    Console.WriteLine(@"/ \");
                    break;

            }

        }

    }
}
