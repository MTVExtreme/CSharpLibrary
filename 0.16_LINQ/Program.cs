using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() {VIN = "A1", Make = "DeathStriker", Model = "Booyo", Price = 53500, Year = 2012},
                new UsedCar() {VIN = "B2", Make = "Ford", Model = "Flaxen", Price = 5670, Year = 2014},
                new UsedCar() {VIN = "C3", Make = "Chexiv", Model = "Ban", Price = 3350, Year = 1993},
                new UsedCar() {VIN = "D2", Make = "DornSnaggle", Model = "Tojjk", Price = 3000, Year = 2000},
                new UsedCar() {VIN = "E1", Make = "DeathStriker", Model = "Loran", Price = 12000, Year = 2012},
                new UsedCar() {VIN = "F4", Make = "Chexiv", Model = "Ban", Price = 53500, Year = 2012},
                new UsedCar() {VIN = "G8", Make = "Ford", Model = "Booyo", Price = 8900, Year = 2000},

            };

            var fords = from car in usedCars
                       where car.Make == "Ford"
                       select car;

            foreach(var ford in fords)
            {
                Console.WriteLine("{0} {1} {2} costs {3:C}",ford.Year, ford.Make, ford.Model, ford.Price);
            }
            

            Console.WriteLine("==============");

            var lowPrice = from car in usedCars
                           where car.Price <= 10000 && car.Price > 5000
                           select car;

            foreach (var carz in lowPrice)
            {
                Console.WriteLine("The {0} {1} {2} is a nice low cost car that costs {3:C}", carz.Year, carz.Make, carz.Model, carz.Price);
            }


            Console.WriteLine("================");
            Console.WriteLine("LINQ With Lamba");
            var fordz = usedCars.Where(car => car.Make == "Ford");
            foreach (var ford in fordz)
            {
                Console.WriteLine("The {0} {1} {2} is a nice low cost car that costs {3:C}", ford.Year, ford.Make, ford.Model, ford.Price);
            }
            var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Make == "DeathStriker" || car.Make == "Ford");

            Console.WriteLine("================");
            Console.WriteLine("LINQ With Lamba => 2");
            foreach (var car in niceUsedCars)
            {
                Console.WriteLine("The {0} {1} {2} is a nice used car that costs {3:C}", car.Year, car.Make, car.Model, car.Price);
            }



            Console.ReadLine();

        }
    }
    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
