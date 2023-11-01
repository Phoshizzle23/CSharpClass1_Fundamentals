//C# Fundamentals_Part_12
//06:58:58 – Gracefully Handling Exceptions
using System;

namespace HandlingExceptions 
{
    class Program 
    { 
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\matt_\Downloads\Programming Folder\1. C# Folder\3. MS C# TUT\Project Folder\Part 12\Example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine("There was an issue!!!");
                Console.WriteLine("Check the name of the file!!!");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was an issue!!!");
                Console.WriteLine("Check the name of the directory!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an issue!!!");
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                //Code to finalize
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("Closing application now... ");
            }


            /* 
            string content = File.ReadAllText(@"C:\Users\matt_\Downloads\Programming Folder\1. C# Folder\3. MS C# TUT\Project Folder\Part 12\Example.txt");
            Console.WriteLine(content);
            */

            Console.ReadLine();
        }
    }
}

//############################################################################
//07:20:02 – Understanding Events and Event-Driven Programming
//############################################################################
//07:40:58 – Where to Go from Here