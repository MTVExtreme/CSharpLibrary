using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Loops_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            num[0] = 1;
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;

            int[] lottoNums = new int[] { 15, 4, 16, 23, 42, 7 };
            Console.WriteLine(num[0]);
            Console.WriteLine(lottoNums[3]);

            foreach(int numb in num)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();



        }
    }
}
