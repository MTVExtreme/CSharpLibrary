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
        
        public CharacterType Choosetype(int t)
        {
            switch(t)
            {
                case 0:
                    Console.WriteLine("You are a Ninja");
                    return this.Type = CharacterType.Ninja;
                case 1:
                    Console.WriteLine("You are a Mage");
                    return this.Type = CharacterType.Mage;
                case 2:
                    Console.WriteLine("You are a Paladin");
                    return this.Type = CharacterType.Paladin;
                case 3:
                    Console.WriteLine("You are a Ranger");
                    return this.Type = CharacterType.Ranger;
                default:
                    Console.WriteLine("You are a Human you pleb");
                    return this.Type = CharacterType.Human;

            }
        }

        interface

        public override string ToString()
        {
            return $"The {this.Type} {this.Name} of {this.Faction} => Health Points: {this.HealthPoints}";
        }
    }
}
