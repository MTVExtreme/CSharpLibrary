using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "James","Paul","Kenn","Sheriff"
            };


            Console.WriteLine("Lambda expressions with .ForEach");
            names.ForEach(name => Console.WriteLine(name)); //Does a Foreach

            Console.ReadLine();
        }
    }
}
