using System;
using System.Collections.Generic;

namespace Wordle
{
    class WordHandler
    {
        private IWord Word { get; set; }

        public List<string> GuessedWords { get; set; }

        public int GuessCount { get; set; }

        public int AvailableTries { get; set; } = 5;

        public Dictionary<char, char> Alphabet { get; set; } = new Dictionary<char, char>();

        public WordHandler(IWord word)
        {
            Word = word;

            GuessCount = 0;
            GuessedWords = new List<string>();

            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            foreach (char character in alpha)
            {
                Alphabet.Add(character, 'b');
            }
        }

        public WordHandler(IWord word, int tries) : this(word)
        {
            AvailableTries = tries;
        }

        public string GuessWord()
        {
            Console.WriteLine($"The Hidden word is a {Word.HiddenWord.Length} letter word");

            string guess = string.Empty;

            do
            {
                guess = Console.ReadLine();

                if (!Word.AvailableWords.Contains(guess.ToLower()))
                {
                    Console.WriteLine("Please guess a valid word.");
                }
            }
            while (!Word.AvailableWords.Contains(guess.ToLower()));

            Word.AvailableWords.Remove(guess.ToLower());
            guess = guess.ToLower();
            GuessCount++;
            GuessedWords.Add(guess);

            return guess;
        }
    }

}

