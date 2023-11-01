//C# Fundamentals_Part_10
//05:58:06 – Working with Collections - Super arrays
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace WorkingWithCollections {
    class Program { 
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "MS .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */
            // ArrayLists are dynamically sized, cool features - sorting, remove items

            /* ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);

            foreach (Car car in myArrayList) 
            { 
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
            }
            */

            /*
            // List<T>
            List<Car>myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1); => cannot convert book to car
            foreach (Car car in myList) 
            {
                Console.WriteLine(car.Make + "|" + car.Model);
            }
            */

            //Dictionary <TKey, TValue>
            /*
            Dictionary<string, Car myDicionary = new Dictionary<string, Car>();

            myDicionary.Add(car1.VIN, car1);
            myDicionary.Add(car2.VIN, car2);

            Console.WriteLine(myDicionary["B2"].VIN);
            */

            /*
            // Object initialiser - no need for constructor
            Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3"};
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4"};

            // Colection initialiser
            List<Car> myList = new List<Car>() {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5" },
                new Car { Make = "Nissan", Model = "GTR", VIN = "F6" }
            };
            */

            //06:21:21 – Working with LINQ

            List<Car> mycars = new List<Car>() {                
                new Car { VIN = "A1" , Make = "BMW", Model = "550i", StickerPrice = 55000, Year =  2011},
                new Car { VIN = "B2" , Make = "Ford", Model = "4Runner", StickerPrice = 35000, Year =  2012},
                new Car { VIN = "C3" , Make = "BMW", Model = "745li", StickerPrice = 75000, Year =  2013},
                new Car { VIN = "D4" , Make = "Ford", Model = "Escape", StickerPrice = 25000, Year =  2014},
                new Car { VIN = "E5" , Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2010}
            };
            // LINQ Query
            /*
            var bmws = from car in mycars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */

            var fords = from car in mycars
                       where car.Make == "Ford"
                       select car;
            /*
            var orderedCars = from car in mycars
                              orderby car.Year descending
                              select car;
            */


            // LINQ Method

            //var bmws = mycars.Where(p => p.Make == "BMW" && p.Year == 2011);

            //var orderedCars = mycars.OrderByDescending(p => p.Year);

            /*
            var firstBMW = mycars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            //Console.WriteLine(mycars.TrueForAll(p => p.Year <= 2014));

            /*
            mycars.ForEach(p => p.StickerPrice -= 3000);            
            mycars.ForEach (p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            */

            //Console.WriteLine(mycars.Exists(p => p.Model == "745li"));

            //Console.WriteLine(mycars.Sum(p => p.StickerPrice));         


            /*foreach (var car in bmws) 
            { 
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */



            /* foreach (var car in orderedCars)
            {
                Console.WriteLine("{2} | {0} | {1}", car.Model, car.VIN, car.Year);
            }
            */

            /*
            Console.WriteLine("|");
            
            foreach (var car in fords)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */

            Console.WriteLine(mycars.GetType());
            
            var orderedCars = mycars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.Count());
            Console.WriteLine(orderedCars.GetType());
            
            var bmws = mycars.Where(p => p.Make == "BMW" && p.Year == 2011);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in mycars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model};
            Console.WriteLine(newCars.GetType());


            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }    
        public int StickerPrice { get; set;}
        public int Year { get; set; }


    }

    class Book 
    { 
        public string Author { get; set; }  
        public string Title { get; set; }
        public string ISBN { get; set; }    
    }
}

