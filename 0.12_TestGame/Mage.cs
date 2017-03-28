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
            this.Mana = 30;
            this.HealthPoints = 80;
            this.Speed = 6;
            this.Type = CharacterType.Mage;

        }

        public override string ToString()
        {
            return $"The {this.Type} {this.Name} of {this.Faction} => Health Points: {this.HealthPoints} || Speed: {this.Speed} || Mana: {this.Mana}";
        }
    }
}
