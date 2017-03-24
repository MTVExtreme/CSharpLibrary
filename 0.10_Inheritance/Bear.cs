using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Inheritance
{
    class Bear : Animal
    {
        public bool Hibernate { get; set; }
        public string Meal { get; set; }
        public bool StealsPicnicBasket { get; set; }

        public void Speak()
        {
            Console.WriteLine("Bear says: GRRRRRRRRRRRRRRRRRAAWWW");
        }


    }
}
