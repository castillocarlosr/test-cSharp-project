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
            Console.WriteLine("");
            Console.WriteLine("4) Array Max Result");
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
                Console.WriteLine("Bye bye.");
                return false;
            }
             else if (result == "4")
            {
                ArrayMaxResult();
                return true;
            } 
            else
            {
                OtherKeyPressed();
                return true;
            }
        }

            private static void GuessingGame()
            {
                Console.Clear();
                Console.WriteLine("Guessing numbers from a \"dozen\" game! \"Hope you enjoy!\"");

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
                int counter = 0;
                while (counter < result + 1)
                {
                    Console.Write(counter);
                    Console.Write("-");
                    counter++;
                }
                Console.ReadLine();
            }

            private static void OtherKeyPressed()
            {
            Console.Clear();
            Console.WriteLine("Oh no.....Looks like you didn't type 1, 2, or 3.");
            Console.ReadLine();
            }

            private static void ArrayMaxResult()
            {
            Console.Clear();
            Console.WriteLine("Problem 4:  Sum of Rows.");
            Console.WriteLine("");
            Console.Write("Enter the number of ROWS you want:  ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of COLUMNS you want:  ");
            int columns = int.Parse(Console.ReadLine());

            /*test array below
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            */
            int[,] myArray = new int[rows, columns];
            Random rnd = new Random();
            for (int k = 0; k < myArray.GetLength(0); k++)
            {
                for (int l = 0; l < myArray.GetLength(1); l++)
                {
                    myArray[k, l] = rnd.Next(-99, 99);
                }
            }

            //This is the math addition for the rows.  Display code at the bottom.
            int[] rowSum = new int[myArray.GetLength(0)];
            for (int m = 0; m < myArray.GetLength(0); m++)
            {
                rowSum[m] = 0;
                for (int n = 0; n < myArray.GetLength(1); n++)
                {
                    rowSum[m] += myArray[m, n];
                }
            }
            //Display the random generated array
            Console.WriteLine($"The random generated integers in the array are as follows:");
            for (byte o = 0; o < myArray.GetLength(0); o++)
            {
                Console.Write("[ ");
                for (int p = 0; p < myArray.GetLength(1); p++)
                {
                    //Console.Write($"{myArray[o, p]} ");
                    //string str = (Convert.ToString(myArray[o,p]) + ", ");
                    Console.Write(myArray[o, p] + " ");

                    //Console.Write(str.Replace(" ", ","));

                    /* I want to not have the last comma show up when myAraay[o,p] + "," is displayed in console
                      I dont know how to go about this.  Will look into this*/
                }
                Console.Write("]");
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine(" ");
            //Display the result for the math addition above
            Console.WriteLine($"The sum is: [{string.Join(", ", rowSum)}]");
            Console.ReadLine();
        }
        
    }
}
