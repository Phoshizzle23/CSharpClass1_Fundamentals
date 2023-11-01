// C# Fundamentals Part 2 01:26:00 - 02:41:00
using Microsoft.VisualBasic;
using System.Dynamic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {   //01:26:53 – The if Decision Statement
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: ");

            for (int i = 1; i <= 3; i++) 
            {
                Console.WriteLine(i);
            }
            
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
            {
                message = "You have won a brand new car. ";
                message = message + "You Congrats!!!";

            }
            else if (userValue == "2")
            {
                message = "You have won a brand new boat. ";
                message = message + "You Congrats!!!";

            }
            else if (userValue == "3")
            {
                message = "You have won a brand new house. ";
                message = message + "You Congrats!!!";

            }
            else 
            {
                message = "Please enter a valid option, i,e: 1, 2 or 3. ";
                message = message + "You Lose!!!";
                message += "You Lose!!!"; //concat option

            }

            Console.WriteLine(message);
            Console.WriteLine();

            // if or else
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: ");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }

            string userValue2 = Console.ReadLine();
            string message2 = (userValue2 == "1") ? "boat" : "strand of lint";

            Console.Write("You won a ");
            Console.Write(message2);
            Console.Write(".");

            //shorten the above
            Console.WriteLine("You entered {0}, thefore you won a {1}.", userValue2, message2);
            Console.ReadLine();

            //01:50:24 – Operators, Expressions, and Statements

            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 4;
            a = 5;
            b = 6;

            // There a many mathmatical operator ...

            // addition operator
            x = 3 + 4;
            // subratction
            x = 4 - 3;
            // Multiplicaion
            x = 4 * 3;
            // Division
            x = 4 / 3;
            // Order of operations using parenthesis
            x = (x + y) * (a - b);
            // There are many operators used to evaluate values ...

            // Eqality operator
            if (x == y) { } else { }
            // Greater than operator
            if (x > y) { } else { }
            // Less than operator
            if (x < y) { } else { }
            // Greater than or equal to operator
            if (x >= y) { } else { }
            // less than or equal to operator
            if (x <= y) { } else { }
            // Conditional AND operator
            if ((x > y) && (a > b)) { }
            // Conditional OR operator
            if ((x > y) || (a > b)) { }
            // in-line conditional operator
            // string message2 = (userValue2 == "1") ? "boat" : "car";
            // Member access and Method invocation
            Console.WriteLine("Hi");
            */
            //##################################
            //02:05:36 – for Iteration Statement - Loops
            /*
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }

            // code snipits -> Type 'for' then tab tab
            for (int myValue = 0; myValue < 10; myValue++)
            {
                while (true) // ->Type 'while' then tab tab
                {

                }
            }
            */

            //02:24:04 – Understanding Arrays - working with several values of groups

            // Wrong way to do it below
            /*
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            { }
            else if (number2 == 16) 
            { }
            else if (number3 == 16) 
            { }
            */

            // right way to do it below - Arrays are like working with a tackle box - collection of data you want to keep together
            /*
            Console.WriteLine("Working with arrays!!!");
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            
            Console.WriteLine("Loop thru array and print values");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Print value at index 1");
            Console.WriteLine(numbers[0]);
            Console.WriteLine("Print how may values contained in array");
            Console.WriteLine(numbers.Length);

            Console.WriteLine("Other way to declare arrays!!!");
            int[] numbers2 = new int[] {4, 8, 16, 23, 42 };
            Console.WriteLine("Loop thru array and print values");
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
            Console.WriteLine("Print value at index 5");
            Console.WriteLine(numbers2[4]);
            Console.WriteLine("Print how may values contained in array");
            Console.WriteLine(numbers2.Length);

            string[] names = new string[] {"Eddie", "Alex", "Michael", "David Lee"};
            Console.WriteLine("Loop thru array and print values");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Print value at index 3");
            Console.WriteLine(names[2]);

            Console.WriteLine("Print how may values contained in array");
            Console.WriteLine(names.Length);

            string[] name2 = new string[] { "matt", "woodward", "bella", "Woodward", "kelly", "nguyen" };
            // loop tech 1
            for (int i = 0; i < name2.Length; i++)
            {
                Console.WriteLine(name2[i]);
            }
            // loop tech 2
            foreach (string name in name2) 
            { 
                Console.WriteLine(name);   
            }
            // Reverse a string
            string zig = "You can get what you want out of life " +
                " If you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach  (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            */

            //02:41:42 – Defining and Calling Methods


            //03:12:51 – While Iteration Statement
            //03:30:54 – Working with Strings
            //03:54:24 – Working with Dates and Times
            Console.ReadLine();

        }
    }
}

//Part 3 ###########################################################################

//04:04:51 – Understanding Classes
//04:28:47 – More About Classes and Methods
//05:03:16 – Understanding Scope and Accessibility Modifiers
//05:20:02 – Understanding Namespaces and Working with the .NET Class Library
//05:37:46 – Creating and Adding References to Assemblies
//05:58:06 – Working with Collections - Super arrays
//06:21:21 – Working with LINQ
//06:45:48 – Enumerations and the Switch Decision Statement
//06:58:58 – Gracefully Handling Exceptions
//07:20:02 – Understanding Events and Event-Driven Programming
//07:40:58 – Where to Go from Here