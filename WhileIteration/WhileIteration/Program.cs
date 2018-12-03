using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a valid option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing random numbers game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Oh no.....Looks like you didn't type 1, 2, or 3.");
                return true;
            }
        }

            private static void GuessingGame()
            {
                Console.Clear();
                Console.WriteLine("Guessing numbers game! YAY!?");

                Random myRandom = new Random();
                int randomNumber = myRandom.Next(1, 13);

                int guesses = 0;
                bool incorrect = true;

                do
                {
                    Console.WriteLine("Guess a number between 1 and 12: ");
                    string result = Console.ReadLine();
                    guesses++;
                    if (result == randomNumber.ToString())
                        incorrect = false;
                    else
                        Console.WriteLine("You have chosen POORLY.....");
                }  while (incorrect);
                Console.WriteLine("You have choosen WISELY!  It took you {0} guesses.", guesses);
                Console.WriteLine("Press 'return' or 'enter' key to continue.");

                Console.ReadLine();
            }

            private static void PrintNumbers()
            {
                Console.Clear();
                Console.WriteLine("Print numbers!");
                Console.Write("Type a number.  Any number: ");
                int result = int.Parse(Console.ReadLine());
                int counter = 1;
                while (counter < result + 1)
                {
                    Console.Write(counter);
                    Console.Write("-");
                    counter++;
                }
                Console.ReadLine();
            }
        
    }
}
