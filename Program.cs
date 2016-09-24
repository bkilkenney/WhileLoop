using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)  //Don't need to check for true b/c displayMenu is already set to true
            {
                displayMenu = MainMenu();  //Example of a method being called in a loop
            }

        }

        //Main menu will be it's own method

        private static bool MainMenu()  //While true the main menu method will be called.  The only response that is False is option 3 to exit
        {
            Console.Clear();

            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (answer == "2")
            {
                GuessingGame();
                return true;
            }
            else if (answer == "3")
            {
                return false;  //False means 'don't call main menu method, so the menu will close
            }
            else
            {
                return true;  //Any answer other than 1, 2 or 3 will display the menu again b/c it's true
            }
        }

//*********************************************Next is a method for a print numbers game************************************************************************

        private static void PrintNumbers()
        {
            Console.Clear();

            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            int numberUserEntered = int.Parse(Console.ReadLine());

            int counter = 1;
            while (counter < numberUserEntered + 1)             //+1 or it will stop just short of the number user selected
            {
                Console.Write(counter);
                Console.Write(" ");                
                counter++;
            }
            Console.ReadLine();
        }


//****************************************Next is the method for a guessing game with a do-while loop*************************************************************

        private static void GuessingGame()
        {
            Console.Clear();

            Console.WriteLine("Guessing game!");

            Random myRandomNumber = new Random();
            int randomNumber = myRandomNumber.Next(1, 11);  //dot.Next method will return a random non-negative number, it will be between the parameters listed

            int guesses = 0; //This is how many guesses the user has made so far
            bool incorrect = true;

            do  //Automatically performs the following action before ever checking for condition
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string answer = Console.ReadLine();
                guesses++;

                if (answer == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");

            }
            while (incorrect);
            Console.WriteLine("You win!  It only took you {0} guesses", guesses);

            Console.ReadLine();
        }
    }
}





//Below is one way to create a menu for the user with a while loop************************************************************************************************
//The main method would begin here
/*      {
          MainMenu();
      }

      //Making these loops their own methods
      //While loops are great for having users select from a menu

      private static void MainMenu()
      {
          Console.WriteLine("Please select from the following options:");
          Console.WriteLine("1) Option 1");
          Console.WriteLine("2) Option 2");
          Console.WriteLine("3) Exit");
          string answer = Console.ReadLine();

          if(answer == "1")
          {
              PrintNumbers();
          }
          else if(answer == "2")
          {
              GuessingGame();
          }
          else
          {

          }
      }


      private static void PrintNumbers()
      {
          Console.WriteLine("Print Numbers!");
          Console.ReadLine(); 
      }

      private static void GuessingGame()
      {
          Console.WriteLine("Guessing game!");
          Console.ReadLine(); 

      }
  }
}
*/
