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
            GenerateWord();

            
            
        }
    }

}

