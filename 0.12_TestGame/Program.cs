using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Program
    {
        public void Startup()
        {
            

        }

        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to DURF (Deadly Underground Reference Fighting)");
            Console.WriteLine("What will the name of your Adventurer be?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan of faction are is your adventurer a part of?");
            string faction = Console.ReadLine();
            Console.WriteLine("What class is your adventurer?\n" +
                "0: Ninja\n" +
                "1: Mage\n" +
                "2: Paladin\n" +
                "3: Ranger");
            int playerType = int.Parse(Console.ReadLine());

            switch(playerType)
            {
                case 0:
                    Ninja player1 = new Ninja(name, faction);
                case 1:
                    Mage player1 = new Mage(name, faction);

            }

            PlayerClass player = new PlayerClass(name, faction);
            player.Choosetype(playerType);

            Console.WriteLine(player.ToString());

            Enemy Quagga = new Enemy();
            Quagga.Insult();
            Console.ReadLine();
        }

        public CharacterType Choosetype(int t)
        {
            switch (t)
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





    }
}
