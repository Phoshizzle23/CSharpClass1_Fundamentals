// C# Fundamentals Part 1 00:14:00 - 01:26:00
using Microsoft.VisualBasic;
using System.Dynamic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program { 
        static void Main(string[] args)
        {
            //00:13:50 – Creating Your First C# Program
            //00:30:22 – Understanding Your First C# Program
            //00:47:24 – Working with Code Files, Projects, and Solutions

            //#################################################################################

            Console.WriteLine("Hello World!");
            Thread.Sleep(2000);
            Console.WriteLine("Welcome to my working file for the MS C# Fundamentals TUT!");
            Thread.Sleep(2000);
            Console.WriteLine("Please enter your Name: ");
            string first_Name = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("Hello! " + first_Name);
            

            //00:58:50 – Understanding Data Types and Variables
            //#################################################################################
            
            int x = 7;
            int y = x + 3;
            Console.WriteLine(y);
            Console.WriteLine("What is your Name: ");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
            Console.ReadLine();
            

        }
    }
}


