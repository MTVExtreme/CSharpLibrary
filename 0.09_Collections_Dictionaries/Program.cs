using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "cat", "cute creature" },
                { "dog", "annoying creature" }
            };
            dictionary.Add("fox", "Cool Forest Creature");
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
            }
            Console.ReadLine();
        }
    }
}
