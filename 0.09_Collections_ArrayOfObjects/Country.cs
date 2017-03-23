using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_ArrayOfObjects
{
    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }

        public Country()
        {

        }
        public Country(string name, string capital)
        {
            this.Name = name;
            this.Capital = capital;
            
        }

        public void PrintCountryDetails()
        {
            Console.WriteLine("The Capital of {0} is {1} ", Name, Capital);
        }

    }
}
