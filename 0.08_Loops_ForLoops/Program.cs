using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Loops_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("This is a Loop!");
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i+1);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even!");
                }
                else
                    Console.WriteLine(10 - i);
            }
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);




                Console.ReadLine();

        }
    }
}
