using System;

namespace NumberGuessingGame
{
   class Program
   {
        static void Main(String[] args)
        {
            Starting();             //Method For App NAME and VERSION

            int min, max;           //Two Variable Declaration

            //MinNumberFromUser
            while (true)
            {
                //Min Number
                ChangeColor("Please Enter Min Number: ", ConsoleColor.Yellow);
                String MIN = Console.ReadLine();

                //Condition to Check User Enters Number or NOT
                if (!int.TryParse(MIN, out min))
                {
                    ChangeColor("Please Enter Valid Min Number!", ConsoleColor.Red);
                    continue;
                }
                else
                {
                    min = Int32.Parse(MIN);
                    break;
                }
            }
            //MaxNumberFromUser
            while (true)
            {
                //Max Number
                ChangeColor("Please Enter Max Number: ", ConsoleColor.Yellow);
                String MAX = Console.ReadLine();

                //Condition to Check User Enters Number or NOT
                if (!int.TryParse(MAX, out max))
                {
                    ChangeColor("Please Enter Valid MAX Number!", ConsoleColor.Red);
                    continue;
                }
                else
                {
                    max = Int32.Parse(MAX);
                    break;
                }
            }

            //Boolean Var To Check Min and Max Values are appropriate for Game
            bool minMaxCheck = CheckMinMax(min,max);
            if (minMaxCheck == true)
            {
                furtherGame(min, max);
            }
            else
            {
                ChangeColor("Something is Wrong.Please Try Again.", ConsoleColor.Red);
            }
        }

        //Method For Starting Statements
        static void Starting()
        {
            String GameName = "Number Guessing Game";
            String GameVersion = "1.0.0";
            ChangeColor("Welcome to "+GameName, ConsoleColor.Green);
            ChangeColor("Version:" + GameVersion, ConsoleColor.DarkGreen);
        }

        //Methods for Check Min AND Max Number
        static bool CheckMinMax(int min, int max)
        {
            if (min < max && min != max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method Of Real Game
        static void furtherGame(int min, int max)
        {
            //Hint
            Console.WriteLine("Hint: Guess Number Between {0} and {1}.",min,max);

            while (true)
            {
                //Random Number Generator
                Random random = new Random();
                int Correct_Ans = random.Next(min, max);

                //User's Guess
                ChangeColor("Please Enter Your Guess : ", ConsoleColor.Yellow);
                String userGuess = Console.ReadLine();
                int user_Guess;

                //Check USER input is Int or not
                if (!int.TryParse(userGuess, out user_Guess))
                {
                        ChangeColor("Please Try Again With Integer Guess!", ConsoleColor.Red);
                        continue;
                }
                else if(user_Guess >= min && user_Guess <= max)
                {
                        //Match the Correct Ans with User's Guess
                        if (Correct_Ans != user_Guess)
                        {
                            ChangeColor("Please Try  Again!", ConsoleColor.Red);
                            continue;
                        }
                        else if (Correct_Ans == user_Guess)
                        {
                            ChangeColor("You Got it! Guiness!", ConsoleColor.DarkMagenta);
                            return;
                        }
                }
                else
                {
                    ChangeColor("Please Try Number Inbetween " + min + " - " + max + " !", ConsoleColor.Red);
                    continue;
                }
            
            }
        }

        //Method For Print Messages with Different Font Color
        static void ChangeColor(String text, ConsoleColor color)
        {
            
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }


   }
}
