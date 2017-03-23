using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.PlayerName = "The JS Wizard";
            theJSWizard.Attack();
            theJSWizard.Attack("Dusty Wand");
            theJSWizard.Attack("Dusty Wand", 1);
            Console.ReadLine();
        }
    }
}
