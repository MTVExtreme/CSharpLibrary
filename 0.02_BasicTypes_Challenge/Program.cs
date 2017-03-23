using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            int test2;
            string stoo;
            string year = "1997";
            float Lareg = 89f;
            float pen;
            double cheesewagon = 556.89;
            double Hellow;
            decimal holygrail = 78.353674758586523235267267863876377662476m;
            decimal oops;

            test2 = 7;
            stoo = "large";
            pen = 23f;
            Hellow = 3.16;
            oops = 88.8888888888m;
            bool fun = true;
            bool cheese;

            cheese = false;

            Console.WriteLine(age);
            Console.WriteLine(test2);
            Console.WriteLine(stoo);
            Console.WriteLine(year);
            Console.WriteLine(Lareg);
            Console.WriteLine(pen);
            Console.WriteLine(cheesewagon);
            Console.WriteLine(Hellow);
            Console.WriteLine(holygrail);
            Console.WriteLine(oops);

            int ayear = Int32.Parse(year);

            ayear++;

            

            Console.WriteLine("Hello my name is Tyler I am {0} years old. I was born in {1}",age, ayear);
            Console.ReadLine();



        }
    }
}
