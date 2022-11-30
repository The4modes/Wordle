using System;
using System.Collections.Generic;

namespace Wordle
{
    class WordHandler
    {
        private IWord Word { get; set; }

        public List<string> GuessedWords { get; set; }

        public int GuessCount { get; set; }

        private int AvailableTries { get; set; }

        public WordHandler()
        {
            AvailableTries = 6;
            GuessCount = 0;
            GuessedWords = new List<string>();
        }

        public WordHandler(int tries) :this()
        {
            AvailableTries = tries;
        }

        public void CheckWord(string guessedWord)
        {
            throw new NotImplementedException("Have not implemented code for the check word method");
        }
    }

}

