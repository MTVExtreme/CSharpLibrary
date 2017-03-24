using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Dictionaries_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> movies = new Dictionary<string, string> { };
            {
                movies.Add("2000", "Gladiator"  );
                movies.Add("2001", "A Beautiful Mind");
                movies.Add("2002", "Chicago");
                movies.Add("2003", "The Lord of The Rings: Return of the King");
                movies.Add("2004", "Million Dollar Baby");
                movies.Add("2005", "Crash");

            }

            Dictionary<string, string[]> awardWinners = new Dictionary<string, string[]>{ };

            awardWinners.Add("2000", new string[] { "Gladiator", "Chocolat", "Crouching Tiger Hidden Dragon" });
            awardWinners.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom" });
            awardWinners.Add("2002", new string[] { "Chicago", "LGangs of New York", "The Hours" });
            awardWinners.Add("2003", new string[] { "The Lord Of The Rings: Return of the King", "Lost in Translation", "Master and Commander: The Far Side of the World" });
            awardWinners.Add("2004", new string[] { "Million Dollar Baby", "The Aviator", "Finding Neverland" });
            awardWinners.Add("2005", new string[] { "Crash", "Capote", "Brokeback Mountain "});

            foreach(KeyValuePair<string , string[]> winners in awardWinners)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", winners.Key, winners.Value[0], winners.Value[1], winners.Value[2]);
            }

            Console.WriteLine("Please type a year to show the movie that won:");
            //if (int.TryParse(Console.ReadLine(), out int input)) { }

            string input = Console.ReadLine();

            if (movies.ContainsKey(input))
            {
                string valueForKey = movies[input];
                Console.WriteLine("The best picture in {0} was {1}", input, valueForKey);
            }


                Console.WriteLine("Please type a year to show the movies that were up for rward that year: ");

            input = Console.ReadLine();

            if (awardWinners.ContainsKey(input))
            {
                string[] valueForKey = awardWinners[input];
                string nomString = string.Join(", ", valueForKey);
                Console.WriteLine("The nominees in {0} were {1}", input, nomString);
            }
            Console.ReadLine();

        }
    }
}
