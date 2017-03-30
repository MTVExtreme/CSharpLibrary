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

            int gameType = WelcomeScreen();

            PlayerClass player1 = Startup();
            if (gameType == 4)
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

        private static int WelcomeScreen()
        {
            bool playerCheck;
            SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            talkingConsole.Speak("Welcome to derf");
            Console.WriteLine("Welcome to DURF (Deadly Underground Reference Fighting)");
            string durfFlash = @"
                                                                                    
DDDDDDDDDDDDD        UUUUUUUU     UUUUUUUURRRRRRRRRRRRRRRRR   FFFFFFFFFFFFFFFFFFFFFF
D::::::::::::DDD     U::::::U     U::::::UR::::::::::::::::R  F::::::::::::::::::::F
D:::::::::::::::DD   U::::::U     U::::::UR::::::RRRRRR:::::R F::::::::::::::::::::F
DDD:::::DDDDD:::::D  UU:::::U     U:::::UURR:::::R     R:::::RFF::::::FFFFFFFFF::::F
  D:::::D    D:::::D  U:::::U     U:::::U   R::::R     R:::::R  F:::::F       FFFFFF
  D:::::D     D:::::D U:::::D     D:::::U   R::::R     R:::::R  F:::::F             
  D:::::D     D:::::D U:::::D     D:::::U   R::::RRRRRR:::::R   F::::::FFFFFFFFFF   
  D:::::D     D:::::D U:::::D     D:::::U   R:::::::::::::RR    F:::::::::::::::F   
  D:::::D     D:::::D U:::::D     D:::::U   R::::RRRRRR:::::R   F:::::::::::::::F   
  D:::::D     D:::::D U:::::D     D:::::U   R::::R     R:::::R  F::::::FFFFFFFFFF   
  D:::::D     D:::::D U:::::D     D:::::U   R::::R     R:::::R  F:::::F             
  D:::::D    D:::::D  U::::::U   U::::::U   R::::R     R:::::R  F:::::F             
DDD:::::DDDDD:::::D   U:::::::UUU:::::::U RR:::::R     R:::::RFF:::::::FF           
D:::::::::::::::DD     UU:::::::::::::UU  R::::::R     R:::::RF::::::::FF           
D::::::::::::DDD         UU:::::::::UU    R::::::R     R:::::RF::::::::FF           
DDDDDDDDDDDDD              UUUUUUUUU      RRRRRRRR     RRRRRRRFFFFFFFFFFF           ";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(durfFlash);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n|--Menu--|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("0: 3-Person Party (1 Player)"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("NOT IMPLEMENTED\n"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1: 3-Person Party (2 Players)"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("NOT IMPLEMENTED\n"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2: 3-Person Party (3 Players)"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("NOT IMPLEMENTED\n"); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3: 1-Person Party (1 Player)");  
            Console.WriteLine("4: 2-Person Party (2 Players)"); 
            int input = Int32.Parse(Console.ReadLine());

            return input;
               
        }
    }
}
