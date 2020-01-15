using System;

namespace NumberGuessingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            String GameName = "Number Guessing Game";
            String GameVersion = "1.0.0";
            Console.WriteLine("Hello And Welcome to {0} Version:{1}",GameName,GameVersion);


            Console.WriteLine("Hint Guess Number Between 1 - 20.");
            while (true)
            {
                Random random = new Random();
                int Correct_Answer = random.Next(0,20);

                    Console.Write("Please Enter Your Guess: ");
                    String UserGuess = Console.ReadLine();
                int UserInput;
                if (!int.TryParse(UserGuess, out UserInput))
                {
                    Console.WriteLine("Bad INPUT.Please Try With Integer Values");
                }
                else {

                        if (Correct_Answer != Int32.Parse(UserGuess))
                        {
                            if (Int32.Parse(UserGuess) < 0 || Int32.Parse(UserGuess) > 20)
                            {
                                Console.WriteLine("Please Guess inbetween 0-20");
                                continue;
                            }
                            else 
                            {
                                Console.WriteLine("Wrong Answer. Try Again!");
                                continue;
                            }
                            
                        }
                        if(Correct_Answer == Int32.Parse(UserGuess))
                        {
                            Console.WriteLine("Correct Answer.You are Guiness!");
                            return;
                        }
                }
               
            }
            
        }
    }
}
