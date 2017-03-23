using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Loops_ForLoopProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            Console.Write("User please enter your name >");
            string name = Console.ReadLine();

            Console.Write("User please enter your starting number >");
            int startNum = Int32.Parse(Console.ReadLine());

            Console.Write("User please enter your ending number >");
            int endNum = Int32.Parse(Console.ReadLine());

            for(int i = startNum; i <= endNum; i++)
            {
                sum = sum + i;
            }

            Console.Write("Hello, {0} the sum of all numbers {1} through {2} is {3}",name ,startNum,endNum,sum);
            Console.ReadLine();



        }
    }
}
