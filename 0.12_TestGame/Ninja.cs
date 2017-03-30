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
            this.Stamina = 25;
            this.HealthPoints = 85;
            this.Speed = 16;
            this.Type = CharacterType.Ninja;

        }

        public override string ToString()
        {
            return $"The {this.Type} {this.Name} of {this.Faction} => Health Points: {this.HealthPoints} || Speed: {this.Speed} || Stamina: {this.Stamina}";
        }
    }
}


