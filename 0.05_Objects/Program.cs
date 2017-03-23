using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donuts appleCinn = new Donuts();

            appleCinn.Filling = "apple pie";
            appleCinn.isSpecial = false;
            appleCinn.Price = 0.99;
            appleCinn.Type = "Filled";

            Console.WriteLine(appleCinn.Filling);

            Donuts longJohn = new Donuts();
            appleCinn.Filling = "aBavarian Creme";
            appleCinn.isSpecial = true;
            appleCinn.Price = 1.25;
            appleCinn.Type = "Filled";

            Console.WriteLine(longJohn.Filling);

        }
    }
}
