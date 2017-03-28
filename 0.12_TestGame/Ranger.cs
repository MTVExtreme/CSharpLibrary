using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Ranger : PlayerClass
    {
        public int Ammo { get; set; }

        public Ranger(string name, string faction) : base(name, faction)
        {
            //this.Name = name;
            //this.Faction = faction;
            //this.Level = 1;
            this.Ammo = 12;
            this.HealthPoints = 100;
            this.Speed = 13;
            this.Type = CharacterType.Ranger;

        }

        public override string ToString()
        {
            return $"The {this.Type} {this.Name} of {this.Faction} => Health Points: {this.HealthPoints} || Speed: {this.Speed} || Ammo: {this.Ammo}";
        }


    }
}
