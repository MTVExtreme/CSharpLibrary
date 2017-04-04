using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructors_Base
{
    class Person
    {
        //Constructor
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Prop

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void TestMethod()
        {
            Console.WriteLine("Demo method in Person class");
        }
    }
}
