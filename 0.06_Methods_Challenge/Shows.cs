using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Shows
    {
        public int ShowID { get; set; }
        public string ShowName { get; set; }
        public string Genre { get; set; }
        public int Rating{ get; set; }
        public int TotalMinutes { get; set; }

        public void GetSuggestions()
        {
            if (Rating >= 4)
                Console.WriteLine("Show Name: {0}\nShow Genre: {1}\nShow Rating {2}.\nYou should totally watch this show, it's the BOMB!\n", ShowName, Genre, Rating);
            else
                Console.WriteLine("Show Name: {0}\nShow Genre: {1}\nShow Rating {2}\n", ShowName, Genre, Rating);

        }

        public int ShowRuntime()
        {
            int seen;
            bool b = false;


            Console.WriteLine("Total minutes per epsiode: " + this.TotalMinutes + "\n");

            Console.Write("How many minutes have u see of the last episdoe of " + ShowName + "? ");
            while(b == false)
            { 
                if (int.TryParse(Console.ReadLine(), out seen))
                {
                    b = true;
                    MinutesLeft(seen);
                }
                else
                    Console.WriteLine("Error: Value must be an integer");
            }
            return this.TotalMinutes;

        }

        //Methods that have parameters
        public string WhoViewed(string user, string time)
        {
            string details = user + " watched this at " + time;
            return details;
        }

        public int MinutesLeft(int minutesViewed)
        {
            int minutesLeft = this.TotalMinutes - minutesViewed;
            Console.WriteLine("\nYou have {0} minutes left", minutesLeft);
            Console.WriteLine("Hit enter to Continue\n");
            Console.ReadLine();

            return minutesViewed;
        }

    }
}
