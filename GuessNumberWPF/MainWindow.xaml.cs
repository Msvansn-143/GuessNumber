using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GuessNumberWPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
   // MainWindow mainWindow = new MainWindow();
   
    
    public MainWindow()
    {
      InitializeComponent();
      //this.Loaded += MainWindow_Loaded;
     // WPFGuessNumber wPFGuessNumber = new WPFGuessNumber(this);
     //MainWindow mainWindow = new MainWindow(); 
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
     System.Windows.MessageBox.Show("Welcome to the application!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
     System.Windows.MessageBox.Show("Guess a Number between 1 and 10");
    }

    private void Submit_Click(object sender, RoutedEventArgs e)
    {
      //string str = txtGuess.Text;
      while(true) { 
       // txtGuess.Clear();
        //txtGuess.Focus();
      if (string.IsNullOrEmpty(txtGuess.Text) | int.Parse(txtGuess.Text)<0 | int.Parse(txtGuess.Text)>10)
      {
       System.Windows.MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
          
       MainWindow mainWindow = new MainWindow(); 
        mainWindow.Show();
        txtGuess.Clear();
          txtGuess.Focus();
          continue;
          //  int userGuess = int.Parse(txtGuess.Text);
          // Game logic here

        }
      if(Regex.IsMatch(txtGuess.Text, @"^[a-zA-Z]+$"))
        {
       System.Windows.MessageBox.Show("Please enter a Number not Alphabet");
          
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        txtGuess.Clear();
          txtGuess.Focus();
          continue;
        }
      else {
        int userGuess = int.Parse(txtGuess.Text);
          // WPFGuessNumber.GuessNumber(Convert.ToInt32(txtGuess.Text));
          while (true)
          {

            // int correctNumber = 7;
            Random R = new Random();

            int correctNumber = R.Next(1, 10);

            int guess = 0;

            guess = userGuess;

            while (guess != correctNumber)
            {

              //if (Convert.ToBoolean(input))
              //{

              //  //MessageBox.Show("Please enter a Number not Alphabet");
              //  continue;
              //}
              guess = userGuess;
              if (guess != correctNumber)
              {
                MessageBoxResult result = System.Windows.MessageBox.Show("Wrong number ,please try again", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);

                  MainWindow mainWindow1 = new MainWindow();
                //  mainWindow1.Show();
                 mainWindow1.Show();
                System.Windows.MessageBox.Show("Enter another number between 1 and 10");
                txtGuess.Clear();

            txtGuess.Focus(); 
                continue;



                
             // txtGuess.Focus();

              }

            }
            System.Windows.MessageBox.Show("You are CORRECT!!. ");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            txtGuess.Clear();
            //System.Windows.MessageBox.Show("Play Again");
          }

          MessageBoxResult answer = System.Windows.MessageBox.Show("Play Again!?", "Confirmation", MessageBoxButton.YesNo);
          switch (answer)
          {
            case MessageBoxResult.Yes:
              continue;

            case MessageBoxResult.No:
              break;

          }

        }
      }

    }

    private void txtGuess_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
  }
}