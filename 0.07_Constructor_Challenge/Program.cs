using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Constructor_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MoblePhone> list = new List<MoblePhone>(5);

            MoblePhone tyler = new MoblePhone("LG", "K7");
            MoblePhone jared = new MoblePhone("Samsung", "Galaxy S");
            MoblePhone ethan = new MoblePhone("Iphone", "6");
            MoblePhone ashley = new MoblePhone("LG", "K7");
            MoblePhone bob = new MoblePhone("LG", "Bez");

            list.Add(tyler);
            list.Add(jared);
            list.Add(ethan);
            list.Add(ashley);
            list.Add(bob);

           // MoblePhone.PhonesOwned();

            foreach (MoblePhone item in list)
            {
                item.PhonesOwned();
            }
            Console.ReadLine();


        }
    }
}
