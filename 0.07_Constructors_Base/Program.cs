using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructors_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chris = new Person("Chris", "Sullivan");

            Minor mahri = new Minor("Mahri", "Vermillion", true);

            chris.TestMethod();
            mahri.DemoMethod();

            Person kenn = new Minor("Keen", "Pascascio", true);

            kenn.TestMethod();

        }
    }
}
