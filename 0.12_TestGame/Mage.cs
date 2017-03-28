using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Mage : PlayerClass
    {
        public int Mana { get; set; }

        public Mage(string name, string faction) : base(name, faction)
        {
            //this.Name = name;
            //this.Faction = faction;
            //this.Level = 1;
            this.Mana = 30;
            this.HealthPoints = 80;
            this.Speed = 6;

        }
    }
}
