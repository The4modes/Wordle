using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Wordle
{
    class AnimalWord : Word
    {
        public AnimalWord()
        {
            AvailableWords = File.ReadAllLines(Path.GetFullPath(@"../../../animals.txt")).ToList<string>();

            for (int i = 0; i < AvailableWords.Count; i++)
            {
                AvailableWords[i] = AvailableWords[i].ToLower();
            }

            GenerateWord();
        }
    }

}

