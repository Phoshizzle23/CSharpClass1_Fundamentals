// C# Fundamentals Part 3 02:41:00 - 03:12:24
using Microsoft.VisualBasic;
using System.Dynamic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMethod //02:41:42 – Defining and Calling Methods
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("The Name Game");
            
            Console.Write("Whats your first name?: ");
            string firstName = Console.ReadLine();

            Console.Write("Whats yor last name?: ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?: ");
            string city = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray) 
            { 
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray) 
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityArray) 
            { 
                result += item;
            }

            Console.WriteLine("Results: " + result);
            */

            
            
            DisplayResult(ReverseString(firstName), 
                ReverseString(lastName), 
                ReverseString(city));


            Console.ReadLine();
        }

        private static string ReverseString(string message) 
        {            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
            
        }
        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        
    }
    
}
//03:12:51 – While Iteration Statement
//03:30:54 – Working with Strings
//03:54:24 – Working with Dates and Times


//Part  ###########################################################################

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