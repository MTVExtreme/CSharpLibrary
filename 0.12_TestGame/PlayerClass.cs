using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    
    class PlayerClass
    {
        public string Name { get; set; }
        public string Faction { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int Speed { get; set; }
        public CharacterType Type {get; set;}

        public PlayerClass(string name, string faction, CharacterType type = CharacterType.Human)
        {
            this.Name = name;
            this.Faction = faction;
            this.Level = 1;
        }

        public override string ToString()
        {
            return $"The {this.Type} {this.Name} of {this.Faction} => Health Points: {this.HealthPoints} || Speed: {this.Speed}";
        }
    }
}
