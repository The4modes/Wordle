using System.Linq;
using System.IO;

namespace Wordle
{
    class Wordle : Word
    {
        public Wordle()
        {
            AvailableWords = File.ReadAllLines(Path.GetFullPath(@"../../../valid-wordle-words.txt")).ToList<string>();

            GenerateWord();

            
        }
    }

}

