using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11.AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Acura tl = new Acura("TL", 2000, 500);

            Console.WriteLine(tl.AcuraDetails());
            Console.ReadLine();
        }
    }

}

/******Keyword***************Applicable To***************Meaning******************************************		
        public 				  Class, Member				No restrictions
        protected			  Member					Access limited to the class and derived classes
        private				  Member					Access limited to the class.

        internal              Class, Member				Access limited to the current assembly		
    protected internal 		  Member					Access limited to current assembly and derived types

**********************************************************************************************************/
