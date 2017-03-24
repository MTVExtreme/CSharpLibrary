using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear barryTheBear = new Bear();

            PolarBear frostyBear = new PolarBear();

            barryTheBear.Weight = 2000;

            Cat cuteKitty = new Cat();

            cuteKitty.NumberOfLegs = 4;

            cuteKitty.DrinksMilk = true;

            barryTheBear.Walks();
            barryTheBear.Speak();

            cuteKitty.Play();
            cuteKitty.Drink();
            Console.ReadLine();
        }
    }
}
