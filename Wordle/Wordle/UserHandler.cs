using System;
using System.Collections.Generic;

namespace Wordle
{
    abstract class UserHandler
    {
        public static int GetTries()
        {
            Console.WriteLine("Do you want more than 5 guesses?");

            if(Console.ReadLine().ToLower() == "yes")
            {
                return GetTries(5);
            }
            
            return 5;
        }

        private static int GetTries(int minimumTries)
        {
            Console.WriteLine("How many guesses do you want to have?\n minimum is 5.");

            int result;

            while (!int.TryParse(Console.ReadLine(), out result) || result < minimumTries)
            {
                Console.Clear();
                Console.WriteLine("Not a legal number");
            }

            return result;
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
                else if (letter[1] == 'b')
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(letter[0]);
                }
                else
                {
                    throw new Exception("A color for the charachter was never assigned");
                }

                Console.ResetColor();
            }
        }
    }
}

