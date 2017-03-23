using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructor_Challenge
{
    class MoblePhone
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public MoblePhone()
        {

        }

        public MoblePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
      
        }

        public void PhonesOwned()
        {
            Console.WriteLine("Phone Make and Model: {0} {1}", this.Make, this.Model);
        }

    }
}
