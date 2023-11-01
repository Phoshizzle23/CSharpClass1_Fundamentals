/*
##################################################################################
################################## Part  6 #######################################
##################################################################################
*/

using System;
using System.Text;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //04:04:51 – Understanding Classes - Car Lot App
            //04:28:47 – More About Classes and Methods

            /* Hard to keep track of the info without classes
            string car1Make;
            string car1Model;
            int car1Year;
            string car1Color;
            */

            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Sliver";

            Car myOtherCar;
            myOtherCar = new Car();
            myOtherCar.Make = "Ford";
            myOtherCar.Model = "Mustang";
            myOtherCar.Year = 1966;
            myOtherCar.Color = "Red";

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Console.WriteLine("{0}, {1}, {2}, {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color); 
            
            Console.WriteLine("{0}, {1}, {2}, {3}", 
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);


            Console.WriteLine("{0}, {1}, {2}, {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            //decimal value = DetermineMarketvalue(myCar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.DetemineMarketValue());
            Console.ReadLine();
        }

        private static decimal DetermineMarketvalue(Car car) 
        {
            decimal carValue = 100.0M;

            return carValue;
        }
    }
    class Car
    { 
        public string Make { get; set; }
        public string Model { get; set; }  
        public int Year { get; set; }   
        public string Color { get; set; }

        public Car()
        { 
            // Default Values
            // You could load from a configuration file, database etc.
            this.Make = "Nissan"; 
        }

        //Over loaded constructor
        public Car(string make, string model, int year, string color) 
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public decimal DetemineMarketValue() 
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else 
                carValue = 2000;
            return 
                carValue;
        }

    }
}
//05:03:16 – Understanding Scope and Accessibility Modifiers
//05:20:02 – Understanding Namespaces and Working with the .NET Class Library
//05:37:46 – Creating and Adding References to Assemblies
//############################################################################
//05:58:06 – Working with Collections - Super arrays
//06:21:21 – Working with LINQ
//06:45:48 – Enumerations and the Switch Decision Statement
//06:58:58 – Gracefully Handling Exceptions
//07:20:02 – Understanding Events and Event-Driven Programming
//############################################################################
//07:40:58 – Where to Go from Here