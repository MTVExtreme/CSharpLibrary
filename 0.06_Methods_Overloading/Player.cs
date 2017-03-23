using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Overloading
{
    class Player
    {
        //Attack X 3
        public string PlayerName { get; set; }

        public void Attack()
        {
            Console.WriteLine("{0} attacked for 5 points", PlayerName);
        }
        public void Attack(string weapon)
        {
            Console.WriteLine("{0} attacked with the rusty {1}", PlayerName, weapon);
        }
        public void Attack(string weapon, int attackPoints)
        {
            Console.WriteLine("{0} attacked with the rusty {1} for {2} points" , PlayerName, weapon, attackPoints);
        }
    }
}
