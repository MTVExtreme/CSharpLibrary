using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructors_Base
{
    class Minor : Person
    {   //CTOR 1
        public Minor(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        //CTOR 2
        public Minor(string firstName, string lastName, bool IsInSchool) : base(firstName, lastName)
        {

        }
        //Prop
        public bool IsInSchool { get; set; }

        public void DemoMethod()
        {
            Console.WriteLine("Demon Method in Minor Class");
        }
    }
}
