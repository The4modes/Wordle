using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Wordle
{
    class Wordle : Word
    {
        public Wordle()
        {
            AvailableWords = File.ReadAllLines(Path.GetFullPath(@"../../../valid-wordle-words.txt")).ToList<string>();

            for (int i = 0; i < AvailableWords.Count; i++)
            {
                AvailableWords[i] = AvailableWords[i].ToLower();
            }

            GenerateWord();


        }

        public override List<char[]> CheckWord(WordHandler wordHandler)
        {
            string guessedWord = wordHandler.GuessWord();

            List<char[]> strings = new List<char[]>();

            for (int i = 0; i < HiddenWord.Length; i++)
            {
                char[] chars = new char[2];
                chars[0] = guessedWord[i];
                if (guessedWord[i] == HiddenWord[i])
                {
                    wordHandler.Alphabet[chars[0]] = 'g';
                    chars[1] = 'g';
                }
                else if (HiddenWord.Contains(guessedWord[i]))
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
    }

}

