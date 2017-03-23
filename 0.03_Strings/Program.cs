using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string occupations;

            firstname = "Tyler";
            lastname = "Vermillion";
            occupations = "Unemployed";

            string fullname = firstname + " " + lastname;

            Console.WriteLine("Name: {0}\nOccupation: {1}", fullname, occupations);
            Console.ReadLine();


        }
    }
}
