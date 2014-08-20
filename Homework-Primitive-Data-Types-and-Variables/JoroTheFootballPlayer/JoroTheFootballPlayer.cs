using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int numberOfPlays;
            int normalWeekends = 52 - h;
            if (leap == "t")
            {
                numberOfPlays = (normalWeekends * 2 / 3) + h + (p / 2) + 3;
            }
            else
            {
                numberOfPlays = (normalWeekends * 2 / 3) + h + (p / 2);
            }
            Console.WriteLine("Joro plays foorball {0} times in the year", numberOfPlays);
        }
    }
}
