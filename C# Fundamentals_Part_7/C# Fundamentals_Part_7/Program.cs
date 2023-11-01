/*
##################################################################################
################################## Part  7 #######################################
##################################################################################
*/

//05:03:16 – Understanding Scope and Accessibility Modifiers
//05:20:02 – Understanding Namespaces and Working with the .NET Class Library

using System;
using System.Text;

namespace UnderstandingScope {

    class Program 
    {
        //private field
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i <= 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);

                if (1 == 10) 
                { 
                    string l = i.ToString();
                }
                //Console.WriteLine(l);
            }

            k = "Hello, world!"; // Assigning a new value to k

            //Console.WriteLine(i); -> will receive error due to i being out of scope
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod() 
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }

        class Car { 
            public void DoSomething() {
                Console.WriteLine(helperMethod()); 
            }

            private string helperMethod()
            {
                return "Hello World!!!";
            }

        }
    }
}

