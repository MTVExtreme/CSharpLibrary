using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Enemy
    {
        public string Name { get; set; }
        public string Faction { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int Speed { get; set; }
        public int AtkPower1 { get; set; }
        public int AtkPower2 { get; set; }
        public int AtkPower3 { get; set; }




        public void Insult()
        {
            ArrayList insult = new ArrayList {"buck-o", "whimp", "jerk-wad", "window licker", "noob", "neeeerd", "baka" };
            Random rnd = new Random();
            int r = rnd.Next(0, insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }
    }
}
