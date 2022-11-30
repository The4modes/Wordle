using System;

namespace Wordle
{
    class Program
    {
        static void Main(string[] args)
        {
            //WordHandler wordHandler = new WordHandler(UserHandler.GetTries());

            Word word = new Wordle();
            Word animal = new AnimalWord();

            Console.WriteLine(word.HiddenWord);
            Console.WriteLine(animal.HiddenWord);

        }
    }
}

