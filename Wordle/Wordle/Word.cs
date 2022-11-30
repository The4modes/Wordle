using System;
using System.Collections.Generic;

namespace Wordle
{
    abstract class Word : IWord
    {
        public string HiddenWord { get; set; }
        public List<string> AvailableWords { get; set; } = new List<string>();


        public void CheckWord(string guessedWord)
        {
            List<char[]> strings = new List<char[]>();

            //for (int i = 0; i < guessedWord.Length; i++)
            //{
            //    char[] chars = new char[2];

            //    chars[0] = guessedWord[i];

            //    if (guessedWord[i] == HiddenWord[i])
            //    {
                    
            //        'g';
            //    }

            //    strings.Add(chars);
            //}
            

            throw new NotImplementedException();
        }

        protected void GenerateWord()
        {
            Random random = new Random();
            HiddenWord = AvailableWords[random.Next(AvailableWords.Count)];
        }
    }

}

