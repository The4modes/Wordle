using System.Collections.Generic;

namespace Wordle
{
    interface IWord
    {
        public string HiddenWord { get; set; }
        public List<string> AvailableWords { get; set; }

        public void CheckWord(string guessedWord);

    }

}

