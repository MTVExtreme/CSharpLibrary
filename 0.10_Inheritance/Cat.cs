using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Inheritance
{
    class Cat : Animal
    {
        public bool IsCute { get; set; }
        public int HyperLevel { get; set; }
        public bool DrinksMilk { get; set; }

        public void Play()
        {
            Console.WriteLine("Runs acrossed the room playing with a small ball of yarn");
        }

        public void Drink()
        {
            if(DrinksMilk == true)
                Console.WriteLine("Cat goes to milk bowl and drinks milk.");
            else
                Console.WriteLine("Cat goes to milk bowl and becomes apuled by the milk and goes to drink water instead.");
        }

    }
}
