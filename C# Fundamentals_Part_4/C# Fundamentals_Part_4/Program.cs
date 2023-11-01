// C# Fundamentals Part 4
using Microsoft.VisualBasic;
using System.Dynamic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

//03:12:51 – While Iteration Statement - while & dowhile
namespace WhileIteration { 

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
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Print Numbers Game");
            Console.WriteLine("2) Guess Number Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.WriteLine("You have selected the Print Numbers Game!");
                Thread.Sleep(2000);
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {                
                Console.WriteLine("You have selected the Guess Number Game");
                Thread.Sleep(2000);
                GuessingNumber();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("You have selected to exit");
                Thread.Sleep(2000);
                return false;
                
            }
            else 
            {
                Console.WriteLine("Please enter a valid option!");
                Thread.Sleep(2000);
                return true;
            }
                        
        }

        private static void PrintNumbers() 
        {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1) 
            {
                Console.Write(counter);
                Console.Write("_");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingNumber()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrent = true;
            do
            {
                Console.WriteLine("Guess a nubers between 1 and 10: ");
                string result = Console.ReadLine();
                guesses ++;

                if (result == randomNumber.ToString())
                    incorrent = false;
                else
                    Console.WriteLine("Wrong!");

            } while (incorrent);
            Console.WriteLine("Correct! It took you {0}, guesses", guesses);

            Console.ReadLine();
        }


    }
}



