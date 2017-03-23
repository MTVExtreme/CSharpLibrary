using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateShows();

        }

        private static void CreateShows()
        {

            Shows[] showList = new Shows[3];

            Shows show1 = new Shows();
            show1.ShowID = 0;
            show1.ShowName = "Angel Beats!";
            show1.Genre = "Comedy";
            show1.TotalMinutes = 22;
            show1.Rating = 5;

            showList[0] = show1;


            Shows show2 = new Shows();
            show2.ShowID = 1;
            show2.ShowName = "Mirai Nikki";
            show2.Genre = "Horror";
            show2.TotalMinutes = 20;
            show2.Rating = 3;

            showList[1] = show2;

            Shows show3 = new Shows();
            show3.ShowID = 2;
            show3.ShowName = "Gosick";
            show3.Genre = "Mystery";
            show3.TotalMinutes = 21;
            show3.Rating = 4;

            showList[2] = show3;
            //Shows[] showList = {show1, show2, show3};


            foreach (Shows list in showList)
            {

                
                list.GetSuggestions();
                Console.WriteLine(list.WhoViewed("Tyler", "12:30pm"));
                Console.WriteLine();
                list.ShowRuntime();




            }

            Console.ReadLine();

        }


    }
}
