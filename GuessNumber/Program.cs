using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetingUser();
            while(true)
                {

                // int correctNumber = 7;
                Random R = new Random();

                int correctNumber = R.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a Number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red,"Please enter a Number not Alphabet");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number ,please try agaian");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!. ");
                Console.ReadLine();

                Console.WriteLine("Play Again?[Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if(answer=="Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else { return; }
            }
        }
        static void GetAppInfo()
        {

            string appName = "Guess Number";
            string appVersion = "1.0.0";
            string appDeveloper = "SAM";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appDeveloper);

            Console.ResetColor();
        }
        static void GreetingUser()
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", name);

        }
        static void PrintColorMessage(ConsoleColor color,string Message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
