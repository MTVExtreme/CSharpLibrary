using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Country[] countries = new Country[10];
            countries[0] = new Country("Honduras", "Tegucigalpa");
            countries[1] = new Country("Italy", "Rome");
            countries[2] = new Country("USA", "Washington D.C.");
            countries[3] = new Country("Israel", "Jerusalem");
            countries[4] = new Country("Peru", "Lima");
            countries[5] = new Country("Japan", "Tokyo");
            countries[6] = new Country("Australia", "Sydney");
            countries[7] = new Country("Nicaragua", "Managua");
            countries[8] = new Country("China", "Beijing");
            countries[9] = new Country("South Korea", "Seoul");

            foreach(var item in countries)
            {
                item.PrintCountryDetails();
            }
            Console.ReadLine();




        }
    }
}
