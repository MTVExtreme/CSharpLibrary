using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Ninja : PlayerClass
    {
        public int Stamina { get; set; }

        public Ninja(string name, string faction) : base(name, faction)
        {
            //this.Name = name;
            //this.Faction = faction;
            //this.Level = 1;
            this.Stamina = 25;
            this.HealthPoints = 85;
            this.Speed = 16;

        }
    }
}
