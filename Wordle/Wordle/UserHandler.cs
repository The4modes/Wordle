using System;
using System.Collections.Generic;

namespace Wordle
{
    abstract class UserHandler
    {
        public static int GetTries()
        {
            Console.WriteLine("Write the amount of tries you want to have\n" +
                "The number of tries need to be more than 3");

            int result;

            while(!int.TryParse(Console.ReadLine(), out result) || result < 3)
            {
                Console.Clear();
                Console.WriteLine("Not a legal number");
            }
            
            return result;
        }

        public List<char[]> CheckWord(string guessedWord)
        {

            throw new NotImplementedException();


        }

        public static void DisplayColors(List<char[]> colors)
        {
            foreach (char[] letter in colors)
            {
                if (letter[1] == 'g')
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(letter[0]);
                }
                else if (letter[1] == 'y')
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Write(letter[0]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Write(letter[0]);
                }

                Console.ResetColor();
            }
        }
    }
}

