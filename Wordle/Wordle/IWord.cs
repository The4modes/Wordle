using System.Collections.Generic;

namespace Wordle
{
    interface IWord
    {
        public string HiddenWord { get;}
        public List<string> AvailableWords { get;}

        public List<char[]> CheckWord(WordHandler wordHandler);

    }

}

