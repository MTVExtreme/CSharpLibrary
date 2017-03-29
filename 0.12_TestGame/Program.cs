using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Program
    {  
        static void Main(string[] args)
        {

            bool twoPlayer = WelcomeScreen();

            PlayerClass player1 = Startup();
            if (twoPlayer == true)
            { 
                PlayerClass player2 = Startup();
            }

            Console.ReadLine();

            RabidWolf Wolf = new RabidWolf();
            Wolf.Insult();
            Wolf.WolfAttack(player1);
            Console.ReadLine();

        }

        private static PlayerClass Startup()
        {
            PlayerClass player1;

            Console.WriteLine("\nWhat will the name of your Adventurer be?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan of faction are is your adventurer a part of?");
            string faction = Console.ReadLine();
            Console.WriteLine("What class is your adventurer?\n" +
                "0: Ninja\n" +
                "1: Mage\n" +
                "2: Paladin\n" +
                "3: Ranger");
            int playerType = int.Parse(Console.ReadLine());


            if (playerType == 0)
            {
                player1 = new Ninja(name, faction);
            }
            else if (playerType == 1)
            {
                player1 = new Mage(name, faction);
            }
            else if (playerType == 2)
            {
                player1 = new Paladin(name, faction);
            }
            else if (playerType == 3)
            {
                player1 = new Ranger(name, faction);
            }
            else
            {
                player1 = new PlayerClass(name, faction);
            }

            //PlayerClass player = new PlayerClass(name, faction);
            //player.Choosetype(playerType);


            Console.WriteLine(player1.ToString());
            return player1;
        }

        private static bool WelcomeScreen()
        {
            bool playerCheck;
            SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            talkingConsole.Speak("Welcome to derf");
            Console.WriteLine("Welcome to DURF (Deadly Underground Reference Fighting)");
            Console.Write("Would you like 1 or 2 player? If you want 2 players type Y >");
            string input = Console.ReadLine();
            
                if (input.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                playerCheck = true;
                return playerCheck;
            }
            else
            {
                playerCheck = false;
                return playerCheck;
            }
               
        }
    }
}
