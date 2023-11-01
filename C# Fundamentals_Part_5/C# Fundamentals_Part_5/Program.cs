// C# Fundamentals Part 5
using System;
using System.Text;

namespace WorkingWithString 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //03:30:54 – Working with Strings
            //string myString = "My \"so-called\" life";
            //string myString = "What if i need a \nnew line";
            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your C:\ drive";
            //string myString = String.Format("{0} {1}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);
            //Custom format is '#' key
            //string myString = string.Format("Phone number: {0: (###) ###-####}", 1234567890);

            //string myString = " That summer we took threes across the board: ";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            /*
            //myString = String.Format("Length before: {0} -- Length after: {1}", 
                myString.Length,
                myString.Trim().Length);
            */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //stringBuilder

            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++) 
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
            */

            //03:54:24 – Working with Dates and Times

            DateTime myVale = DateTime.Now;
            //Console.WriteLine(myVale.ToString());
            //Console.WriteLine(myVale.ToShortDateString());
            //Console.WriteLine(myVale.ToShortTimeString());
            //Console.WriteLine(myVale.ToLongDateString());
            //Console.WriteLine(myVale.ToLongTimeString());
            //Console.WriteLine(myVale.AddDays(3).ToLongDateString()); //-> see the date in 3 days time
            //Console.WriteLine(myVale.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myVale.AddDays(-3).ToLongDateString()); //-> see the date 3 days ago
            //Console.WriteLine(myVale.Month);

            //DateTime myBirthday = new DateTime(1988, 03, 31);
            //Console.WriteLine(myBirthday.ToShortDateString());
            DateTime myBirthday = DateTime.Parse("31/03/1988");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            DateTime myWedding = DateTime.Parse("15/11/2015");
            TimeSpan daysMarried = DateTime.Now.Subtract(myWedding);
            Console.WriteLine(daysMarried.TotalDays);
            DateTime bellaBirthday = DateTime.Parse("29/10/2019");
            TimeSpan BellaAge = DateTime.Now.Subtract(bellaBirthday);
            Console.WriteLine(BellaAge.TotalDays);
        }

    }
}


/*
##################################################################################
################################## Part  6 #######################################
##################################################################################
*/
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