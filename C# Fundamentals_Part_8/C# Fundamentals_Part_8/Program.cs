/*
##################################################################################
################################## Part  8 #######################################
##################################################################################
*/

//05:20:02 – Understanding Namespaces and Working with the .NET Class Library


using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{

    class Program
    {
        static void Main(string[] args)
        { 
            //site:microsoft.com write to a text file c#
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\matt_\\Downloads\\Programming Folder\\1. C# Folder\\3. MS C# TUT\\Project Folder\\Part 8\\Test.txt");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            Console.ReadLine();
        }

        private static void DownloadString(string address)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://learn.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=net-7.0");

            Console.WriteLine(reply);
        }
    }

}
