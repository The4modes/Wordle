using System;
using System.Collections.Generic;

namespace Wordle
{
    partial class Program
    {
        class GameHandler
        {
            private WordHandler WordHandler { get; set; }
            private IWord Word { get; set; }

            public GameHandler(WordHandler wordHandler, IWord word)
            {
                WordHandler = wordHandler;
                Word = word;
            }

            public void RunGame()
            {
                for (int i = 0; i < WordHandler.AvailableTries; i++)
                {
                    UserHandler.DisplayColors(Word.CheckWord(WordHandler));

                    List<char[]> chars = new List<char[]>();

                    foreach (var item in WordHandler.Alphabet)
                    {
                        chars.Add(new char[] { item.Key, item.Value });
                    }

                    Console.WriteLine();
                    UserHandler.DisplayColors(chars);
                    Console.WriteLine();

                    foreach (var item in WordHandler.GuessedWords)
                    {
                        if (item == Word.HiddenWord)
                        {
                            i = WordHandler.AvailableTries;
                        }
                    }
                }

                Console.WriteLine(Word.HiddenWord);
            }

            public static IWord ChooseMode(string[] gameModes)
            {
                Console.WriteLine("Vilken game mode vill du spela?");

                for (int i = 0; i < gameModes.Length; i++)
                {
                    Console.WriteLine(gameModes[i]);
                }

                switch (Console.ReadLine())
                {
                    case "wordle":
                        return new Wordle();
                    case "animals":
                        return new AnimalWord();
                    default:
                        throw new NotImplementedException("Choosen game mode does not exist");
                }
            }
        }
    }
}

