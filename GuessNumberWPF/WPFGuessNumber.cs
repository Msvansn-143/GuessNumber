using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;



namespace GuessNumberWPF
{
   public class WPFGuessNumber 
    {
    private MainWindow _mainWindow;
    public WPFGuessNumber(MainWindow mainWindow)
    {
      _mainWindow = mainWindow;
    }
    //public static void GetAppInfo()
    // {

    //   string appName = "Guess Number";
    //   string appVersion = "1.0.0";
    //   string appDeveloper = "SAM";

    //   Console.ForegroundColor = ConsoleColor.Green;

    //   Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appDeveloper);

    //   Console.ResetColor();
    // }
    //public static void GreetingUser()
    // {
    //   Console.WriteLine("What is your Name?");
    //   string name = Console.ReadLine();

    //   Console.WriteLine("Hello {0}, Let's play a game...", name);

    // }


    public static void GuessNumber(int input)
    {

      
      while (true)
      {

        // int correctNumber = 7;
        Random R = new Random();

        int correctNumber = R.Next(1, 10);

        int guess = 0;
        
        guess = input;

        while (guess != correctNumber)
        {

          //if (Convert.ToBoolean(input))
          //{

          //  //MessageBox.Show("Please enter a Number not Alphabet");
          //  continue;
          //}
          guess = input;
          if(guess != correctNumber)
          {
            MessageBox.Show("Wrong number ,please try again", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            
          }
          
        
          
        }
        MessageBox.Show("You are CORRECT!!. ");
       

         MessageBoxResult answer = MessageBox.Show("Play Again!?", "Confirmation", MessageBoxButton.YesNo);
        switch (answer)
        {
          case MessageBoxResult.Yes:
            continue;

            case MessageBoxResult.No:
            break;

        }
        
      }
    }
   public static void PrintColorMessage(ConsoleColor color, string Message)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(Message);
      Console.ResetColor();
    }
  }
}
