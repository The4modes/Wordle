using System;
namespace Wordle
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IWord word = GameHandler.ChooseMode(new string[] { "wordle", "animals" });

            int guesses = UserHandler.GetTries();

            WordHandler wordHandler;

            if (guesses > 5)
            {
                wordHandler = new WordHandler(word, guesses);
            }
            else
            {
                wordHandler = new WordHandler(word);
            }

            GameHandler gameHandler = new GameHandler(wordHandler, word);

            gameHandler.RunGame();
        }
    }
}

