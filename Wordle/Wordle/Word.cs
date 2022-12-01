using System;
using System.Collections.Generic;

namespace Wordle
{
    abstract class Word : IWord
    {
        public string HiddenWord { get; protected set; }
        public List<string> AvailableWords { get; protected set; } = new List<string>();

        public virtual List<char[]> CheckWord(WordHandler wordHandler)
        {
            string guess = wordHandler.GuessWord();

            List<char[]> strings = new List<char[]>();

            for (int i = 0; i < guess.Length; i++)
            {
                char[] chars = new char[2];
                chars[0] = guess[i];

                if (HiddenWord.Contains(guess[i]))
                {
                    wordHandler.Alphabet[chars[0]] = 'y';
                    chars[1] = 'y';
                }
                else
                {
                    chars[1] = 'b';
                }

                strings.Add(chars);
            }

            return strings;
        }

        protected void GenerateWord()
        {
            Random random = new Random();
            HiddenWord = AvailableWords[random.Next(AvailableWords.Count)];
        }
    }

}

