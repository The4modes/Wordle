using System;
using System.Collections.Generic;

namespace Wordle
{
    abstract class Word : IWord
    {
        public string HiddenWord { get; set; }
        public List<string> AvailableWords { get; set; }

        public void CheckWord(string guessedWord)
        {
            throw new NotImplementedException();
        }

        protected void GenerateWord()
        {
            Random random = new Random();
            HiddenWord = AvailableWords[random.Next(AvailableWords.Count)];
        }
    }

}

